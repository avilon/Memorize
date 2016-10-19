using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Memorize.Model;

namespace Memorize
{
    public delegate void RoundFinish();

    public partial class ChoiceForm : Form
    {
        public ChoiceForm()
        {
            InitializeComponent();
            Init();
        }

        public void RegisterRoundFinish(RoundFinish rf)
        {
            this.roundFinish += rf;
        }

        private void Init()
        {
            rand = new Random(DateTime.Now.Millisecond);

            //pnlWorkArea.Dock = DockStyle.Fill;
            pnlChoice.Dock = DockStyle.Fill;
            choiceVariants = Properties.Settings.Default.ChoiceVariants;
            pnlChoice.AutoSize = true;
        
            SetupCells();
            SetupLabels();
        }

        private void SetupCells()
        {
            switch (choiceVariants)
            {
                case 4: SetGrid(2, 2); break;
                case 6: SetGrid(3, 2); break;
                case 8: SetGrid(4, 2); break;
                case 9: SetGrid(3, 3); break;
                case 12: SetGrid(4, 3); break;
                case 16: SetGrid(4, 4); break;

                default: SetGrid(2, 2); break;
            }

            items = new DictItem[choiceVariants];
        }

        private void SetupLabels()
        {
            labels = new AnswerLabel[choiceVariants];
            for (int i = 0; i < choiceVariants; i++)
            {
                labels[i] = new AnswerLabel(i);
                labels[i].Dock = DockStyle.Fill;
                labels[i].TextAlign = ContentAlignment.MiddleCenter;
                labels[i].Font = new Font("Tahoma", 12);
                labels[i].SendToBack();
                labels[i].MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnswerLabelMouseClick);

                pnlChoice.Controls.Add(labels[i]);
            }
        }

        private void SetGrid(int cols, int rows)
        {
            pnlChoice.ColumnCount = cols;
            pnlChoice.RowCount = rows;
            pnlChoice.ColumnStyles.Clear();
            pnlChoice.RowStyles.Clear();

            for (int i = 0; i < cols; i++ )
                pnlChoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / cols));
            for (int i = 0; i < cols; i++)
                pnlChoice.RowStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / rows));
        }

        private void ShowQuestion()
        {
            ResetLabels();
            FillNewRange();
            int ndx = rand.Next(choiceVariants);
            lbCaption.Text = items[ndx].Caption;
            rightNdx = ndx;
            for (int i = 0; i < choiceVariants; i++)
            {
                labels[i].Text = items[i].Values[0];
            }
        }

        private void FillNewRange()
        {
            int cnt = 0;
            while (cnt < choiceVariants)
            {
                int next = rand.Next(WordSet.Instance().Count);
                if (!ItemInRange(WordSet.Instance().GetItem(next).Caption))
                {
                    items[cnt] = WordSet.Instance().GetItem(next);
                    cnt++;
                }
            }
        }

        private bool ItemInRange(string str)
        {
            for (int i = 0; i < choiceVariants; i++ )
            {
                if (items[i] != null)
                {
                    if (items[i].Caption == str)
                        return true;
                }
            }
            return false;
        }

        private void ResetLabels()
        {
            foreach (AnswerLabel l in labels)
            {
                l.BackColor = SystemColors.ButtonFace;
            }
        }

        private void AnswerLabelMouseClick(object sender, MouseEventArgs e)
        {
            int ndx = (sender as AnswerLabel).Index;
            if (ndx != rightNdx)
            {
                labels[ndx].BackColor = Color.DarkOrange;
                items[rightNdx].AddTryToTest(false, "choice");
                return;
            }
            items[rightNdx].AddTryToTest(true, "choice");
            tryCnt++;
            if (tryCnt >= MAX_TRY_COUNT)
            {
                if (roundFinish != null)
                {
                    roundFinish();
                }
            }
            ShowQuestion();
        }

        private int choiceVariants;
        private Random rand;
        private DictItem[] items;
        private AnswerLabel[] labels;
        private int rightNdx = -1;
        private int tryCnt;

        private RoundFinish roundFinish;

        private static readonly int MAX_TRY_COUNT = 10;

        private void ChoiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.ChoiceVariants = choiceVariants;
            Properties.Settings.Default.Save();
        }

        private void ChoiceForm_Shown(object sender, EventArgs e)
        {
            ShowQuestion();
            tryCnt = 0;
        }
    }
}
