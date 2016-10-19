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
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            rand = new Random(DateTime.Now.Millisecond);
            InitLabels();
            InitAnserWatchers();
        }

        private void InitLabels()
        {
            rightLabels = new AnswerLabel[MAX_VARIANTS_COUNT];
            leftLabels = new AnswerLabel[MAX_VARIANTS_COUNT];
            for ( int i = 0; i < MAX_VARIANTS_COUNT; i++)
            {
                leftLabels[i] = new AnswerLabel(i);
                leftLabels[i].Dock = DockStyle.Fill;
                leftLabels[i].TextAlign = ContentAlignment.MiddleCenter;
                leftLabels[i].Font = new Font("Tahoma", 12);
                leftLabels[i].SendToBack();
                leftLabels[i].MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnswerLabelMouseClick);

                tlpWords.Controls.Add(leftLabels[i]);

                rightLabels[i] = new AnswerLabel(i);
                rightLabels[i] = new AnswerLabel(i);
                rightLabels[i].Dock = DockStyle.Fill;
                rightLabels[i].TextAlign = ContentAlignment.MiddleCenter;
                rightLabels[i].Font = new Font("Tahoma", 12);
                rightLabels[i].SendToBack();
                rightLabels[i].MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnswerLabelMouseClick);
                tlpWords.Controls.Add(leftLabels[i]);

                tlpWords.Controls.Add(rightLabels[i]);
            }
        }

        private void InitAnserWatchers()
        {
            answerWatchers = new AnswerWatcher[MAX_VARIANTS_COUNT];
            for ( int i = 0; i < MAX_VARIANTS_COUNT; i++)
            {
                answerWatchers[i] = new AnswerWatcher();
            }
        }

        private void CreateNewSet()
        {
            HashSet<int> ndx = new HashSet<int>();
            int cnt = 0;
            while (cnt < 5)
            {
                int next = rand.Next(WordSet.Instance().Count);
                if (!ndx.Contains(next))
                {
                    ndx.Add(next);
                    cnt++;
                }
            }

            
            for (int i = 0; i < MAX_VARIANTS_COUNT; i++ )
            {
                answerWatchers[i].WordIndex = ndx.ElementAt(i);
                leftLabels[i].Text = WordSet.Instance().GetItem(ndx.ElementAt(i)).Caption;
                rightLabels[i].Text = WordSet.Instance().GetItem(ndx.ElementAt(i)).Values[0];
            }
        }

        private void AnswerLabelMouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Label id: " + (sender as AnswerLabel).Index.ToString(), "");
        }

        private AnswerLabel[] rightLabels;
        private AnswerLabel[] leftLabels;
        private AnswerWatcher[] answerWatchers;

        private Random rand;

        private static readonly int MAX_VARIANTS_COUNT = 5;

        private void ConnectForm_Shown(object sender, EventArgs e)
        {
            CreateNewSet();
        }
    }
}
