using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Memorize
{
    public partial class DictionaryForm : Memorize.EditForm
    {
        public DictionaryForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            CheckDictName();    
        }

        private void CheckDictName()
        {
            bbShowDir.Enabled = (edDictName.Text.Length > 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                edDictPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void edDictName_TextChanged(object sender, EventArgs e)
        {
            CheckDictName();
        }
    }
}
