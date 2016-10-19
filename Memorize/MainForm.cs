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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Init();  
        }

        private void Init()
        {
            wordPack = new WordPack();
            wordPack.FilePath = Properties.Settings.Default.DictFilePath;
        }

        private void LoadSettings()
        {
            this.Top = Properties.Settings.Default.MainForm_Top;
            this.Left = Properties.Settings.Default.MainForm_Left;
            this.Width = Properties.Settings.Default.MainForm_Width;
            this.Height = Properties.Settings.Default.MainForm_Height;
            if (String.IsNullOrEmpty(Properties.Settings.Default.DictFilePath))
            {
                WordSet.Instance().Load(Properties.Settings.Default.DictFilePath);
            }
            else
            {
                WordSet.Instance().Load(@"E:\WorkStudio\Memorize\words.dict");
            }
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.MainForm_Top = this.Top;
            Properties.Settings.Default.MainForm_Left = this.Left;
            Properties.Settings.Default.MainForm_Width = this.Width;
            Properties.Settings.Default.MainForm_Height = this.Height;
            Properties.Settings.Default.DictFilePath = WordSet.Instance().FilePath;
            Properties.Settings.Default.Save();
            WordSet.Instance().Save();
        }

        private void AppendDictionary()
        {
            DictionaryForm df = new DictionaryForm();
            df.SetEditMode(EditMode.Append);
            if (df.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void OpenDictionary()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                wordPack.Load(openFileDialog.FileName);
            }
        }

        private void AddWord()
        {
            if (activeForm == null)
                return;

            if (activeForm.Name == "WordListForm" )
            {
                wordListForm.AddWord();
                this.lbAppHint.Text = WordSet.Instance().Count.ToString();
            }
        }

        private void EditWord()
        {
            if (activeForm == null)
                return;

            if (activeForm.Name == "WordListForm")
            {
                wordListForm.EditWord();                
            }
        }

        private void DeleteWord()
        {
            if (activeForm == null)
                return;
            if (activeForm.Name == "WordListForm")
            {
                wordListForm.DeleteWord();
                this.lbAppHint.Text = WordSet.Instance().Count.ToString();
            }
        }

        private void ShowWordListForm()
        {
            if (wordListForm == null)
            {
                wordListForm = new WordListForm();
                wordListForm.TopLevel = false;
                wordListForm.AutoScroll = false;
                wordListForm.FormBorderStyle = FormBorderStyle.None;
                wordListForm.Anchor = AnchorStyles.Left |
                                      AnchorStyles.Right |
                                      AnchorStyles.Bottom |
                                      AnchorStyles.Top;
                pnlWorkArea.Controls.Add(wordListForm);
                wordListForm.Dock = DockStyle.Fill;
                //wordListForm.SetWordPack(wordPack);
            }
            wordListForm.Show();
            wordListForm.BringToFront();
            activeForm = wordListForm;
        }


        private void ShowChoiceForm()
        {
            if (choiceForm == null)
            {
                choiceForm = new ChoiceForm();
                choiceForm.TopLevel = false;
                choiceForm.AutoScroll = false;
                choiceForm.FormBorderStyle = FormBorderStyle.None;
                choiceForm.Anchor = AnchorStyles.Left |
                                      AnchorStyles.Right |
                                      AnchorStyles.Bottom |
                                      AnchorStyles.Top;
                pnlWorkArea.Controls.Add(choiceForm);
                choiceForm.Dock = DockStyle.Fill;
            }
            choiceForm.SetWordPack(wordPack);

            choiceForm.Show();
            choiceForm.BringToFront();
            activeForm = choiceForm;
        }

        private WordListForm wordListForm = null;
        private ChoiceForm choiceForm = null;

        private WordPack wordPack;
        private Form activeForm = null;
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
            if (WordSet.Instance().Count > 0)
            {
                ShowWordListForm();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
        }

        private void mmExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mmDictNew_Click(object sender, EventArgs e)
        {
            AppendDictionary();
        }

        private void mmDictOpen_Click(object sender, EventArgs e)
        {
            OpenDictionary();
        }

        private void mmWordAppend_Click(object sender, EventArgs e)
        {
            AddWord();
        }

        private void mmWordEdit_Click(object sender, EventArgs e)
        {
            EditWord();
        }

        private void mmWordDelete_Click(object sender, EventArgs e)
        {
            DeleteWord();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowChoiceForm();
        }

        private void mmDictList_Click(object sender, EventArgs e)
        {
            ShowWordListForm();
        }
    }
}
