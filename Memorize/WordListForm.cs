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
    public partial class WordListForm : Form
    {
        public WordListForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            listView.Dock = DockStyle.Fill;
            listView.Columns[0].Width = listView.ClientRectangle.Width/2;
            pnlWorkArea.Dock = DockStyle.Fill;
            ShowWords();
        }

        private void ShowWords()
        {
            listView.Items.Clear();
            for ( int i = 0; i < WordSet.Instance().Count; i++)
            {
                listView.Items.Add(WordSet.Instance().GetItem(i).Caption);
            }
        }

        public void AddWord()
        {
            WordEditForm wef = new WordEditForm();
            wef.SetEditMode(EditMode.Append);
            if (wef.ShowDialog() == DialogResult.OK)
            {
                DictItem di = new DictItem();
                di.Caption = wef.Caption;
                di.ReadValues(wef.Values);
                WordSet.Instance().Add(di);
                listView.Items.Add(new ListViewItem(di.Caption));
            }
        }

        public void EditWord()
        {
            WordEditForm wef = new WordEditForm();
            wef.SetEditMode(EditMode.Update);
            wef.Caption = WordSet.Instance().CurrentItem.Caption;
            wef.AddValues(WordSet.Instance().CurrentItem.Values);

            if (wef.ShowDialog() == DialogResult.OK)
            {
                DictItem di = new DictItem();
                di.Caption = wef.Caption;
                di.UpdateValues(wef.Values);
                WordSet.Instance().Update(di);
            }
        }

        public void DeleteWord()
        {

            if (MessageBox.Show("Удлить выбранное слово?", "Удаление элемента", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                WordSet.Instance().DeleteCurrentItem();
            }
        }

        /*
        private void OnAddItem(string caption)
        {
            listView.Items.Add(new ListViewItem(caption));
        }

        private void OnUpdateItem()
        {
            ShowWords();
        }

        private void OnDeleteItem()
        {
            ShowWords();
        }
        */

        private void WordListForm_Activated(object sender, EventArgs e)
        {
            listView.Select();
            listView.Items[0].Selected = true;
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView_Resize(object sender, EventArgs e)
        {
            listView.Columns[0].Width = listView.ClientRectangle.Width / 3;
        }
    }
}
