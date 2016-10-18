using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Memorize
{
    public partial class ValueForm : Form
    {
        public ValueForm()
        {
            InitializeComponent();
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ru-RU"));
        }

        public string Value { get; set; }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Value = textBox.Text;
        }

        private void ValueForm_Activated(object sender, EventArgs e)
        {
            textBox.Select();

            if (!String.IsNullOrEmpty(Value))
            {
                textBox.Text = Value;
                textBox.SelectAll();
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                e.Handled = true;
                Close();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                e.Handled = true;
                Close();
            }
        }

        private void bbOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
