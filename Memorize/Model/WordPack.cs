using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorize.Model
{
    public delegate void DictionaryLoaded(int count);
    public delegate void AddItem(string caption);
    public delegate void UpdateItem();
    public delegate void DeleteItem();

    /// <summary>
    /// Набо слов для изучения
    /// </summary>
    public class WordPack
    {
        public WordPack()
        {
            items = new Dictionary<string, DictItem>();
        }

        public int Count { get { return items.Count; } }
        public int CurrentIndex { get { return selectedIndex; } }
        public DictItem CurrentItem 
        { 
            get 
            { 
                return items.ElementAt(CurrentIndex).Value; 
            }
        }

        public string FilePath 
        { 
            get
            {
                return filePath;
            }
            set
            {
                if (System.IO.File.Exists(value))
                {
                    Load(value);
                }
            }
        }

        public DictItem this[int index]
        {
            get { return items.ElementAt(index).Value; }
        }

        public void Add(DictItem di)
        {
            try
            {
                items.Add(di.Caption, di);
                if (addItem != null)
                {
                    addItem(di.Caption);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString(), "Караул !!!", System.Windows.Forms.MessageBoxButtons.OK);
            }
        }

        public void Update(DictItem di)
        {
            if (items.Remove(di.Caption))
            {
                Add(di);
                if (updateItem != null)
                    updateItem();
            }
        }

        public void Delete(string caption)
        {
            items.Remove(caption);
            if (deleteItem != null)
                deleteItem();
        }

        public void DeleteCurrentItem()
        {
            items.Remove(CurrentItem.Caption);
            if (deleteItem != null)
                deleteItem();
        }

        /// <summary>
        /// Загружает набор слов
        /// </summary>
        /// <param name="path">Размещение фала словаря</param>
        public void Load(string path)
        {
            items.Clear();
            filePath = path;
            using (System.IO.StreamReader reader = new System.IO.StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!String.IsNullOrEmpty(line))
                    {
                        DictItem di = new DictItem();
                        di.Read(line);
                        items.Add(di.Caption, di);
                    }
                }
                selectedIndex = 0;
                if (dictionaryLoaded != null)
                {
                    dictionaryLoaded(items.Count);
                }
            }
        }

        public void Save()
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filePath))
            {
                for ( int i = 0; i < items.Count; i++ )
                {
                    items.ElementAt(i).Value.Write(writer);
                }
            }
        }

        public void SetSelectedIndex(int index)
        {
            selectedIndex = index;
        }

        public DictionaryLoaded dictionaryLoaded;
        public AddItem addItem;
        public UpdateItem updateItem;
        public DeleteItem deleteItem;

        private string filePath;
        private Dictionary<string, DictItem> items;
        private int selectedIndex = 0;
    }
}
