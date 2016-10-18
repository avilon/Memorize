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

        public void SetWordPack(WordPack value)
        {
            wordPack = value;
            wordPack.addItem += OnAddItem;
            wordPack.updateItem += OnUpdateItem;
            wordPack.deleteItem += OnDeleteItem;
            ShowWords();
        }

        private void Init()
        {
            listView.Dock = DockStyle.Fill;
            listView.Columns[0].Width = listView.ClientRectangle.Width/2;
            pnlWorkArea.Dock = DockStyle.Fill;
        }

        private void ShowWords()
        {
            listView.Items.Clear();
            for ( int i = 0; i < wordPack.Count; i++ )
            {
                listView.Items.Add(wordPack[i].Caption);
            }
        }

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

        private WordPack wordPack;

        private void WordListForm_Activated(object sender, EventArgs e)
        {
            listView.Select();
            listView.Items[0].Selected = true;
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            wordPack.SetSelectedIndex(listView.FocusedItem.Index);
        }

        private void listView_Resize(object sender, EventArgs e)
        {
            listView.Columns[0].Width = listView.ClientRectangle.Width / 3;
        }
    }
}
