using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Memorize
{
    public partial class WordEditForm : Memorize.EditForm
    {
        public WordEditForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Values = new List<string>();
        }

        public void AddValues(List<string> list)
        {
            listBox.Items.Clear();
            for ( int i = 0; i < list.Count; i++)
            {
                listBox.Items.Add(list[i]);
            }
            if (listBox.Items.Count > 0)
            {
                listBox.SetSelected(0, true);
            }
            CheckValues();
        }


        private void AddValue()
        {
            InputLanguage currentLanguage = InputLanguage.CurrentInputLanguage;

            ValueForm vf = new ValueForm();
            vf.Text = "Добавить перевод";
            if (vf.ShowDialog() == DialogResult.OK)
            {
                listBox.Items.Add(vf.Value);
}
            textBox.SelectAll();
            InputLanguage.CurrentInputLanguage = currentLanguage;
            CheckValues();
        }

        private void EditValue()
        {
            InputLanguage currentLanguage = InputLanguage.CurrentInputLanguage;

            ValueForm vf = new ValueForm();
            vf.Text = "Редактировать перевод";
            vf.Value = listBox.SelectedItem.ToString();
            if (vf.ShowDialog() == DialogResult.OK)
            {
                int ndx = listBox.SelectedIndex;
                listBox.Items.Remove(listBox.SelectedItem);
                listBox.Items.Insert(ndx, vf.Value);
                listBox.SetSelected(ndx, true);
            }
            textBox.Select();
            textBox.SelectAll();
            InputLanguage.CurrentInputLanguage = currentLanguage;
            CheckValues();
        }

        private void DeleteValue()
        {
            int ndx = listBox.SelectedIndex;
            listBox.Items.Remove(listBox.SelectedItem);
            if (ndx > 0)
            {
                listBox.SetSelected(ndx-1, true);
            }
            textBox.Select();
            textBox.SelectAll();
            CheckValues();
        }

        private void CheckValues()
        {
            if (listBox.Items.Count > 0)
            {
                bbEdit.Enabled = true;
                bbDel.Enabled = true;
            }
            else
            {
                bbEdit.Enabled = false;
                bbDel.Enabled = false;
            }
            UpdateValues();
        }

        private void UpdateValues()
        {
            Values.Clear();
            for ( int i = 0; i < listBox.Items.Count; i++ )
            {
                Values.Add(listBox.Items[i].ToString());
            }
        }

        public string Caption { get; set; }
        public List<string> Values { get; set; }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                AddValue();
            }
        }

        private void bbAdd_Click(object sender, EventArgs e)
        {
            AddValue();
        }

        private void bbEdit_Click(object sender, EventArgs e)
        {
            EditValue();
        }

        private void WordEditForm_Activated(object sender, EventArgs e)
        {
            if (Mode == EditMode.Update)
            {
                textBox.Text = Caption;
                textBox.SelectAll();
                textBox.Select();
            }

            CheckValues();
        }

        private void bbDel_Click(object sender, EventArgs e)
        {
            DeleteValue();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Caption = textBox.Text;
        }

    }
}
