using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorize.Model
{
    internal class WordSetChange
    {
        internal int Count { get; set; }
        internal string OperationName { get; set; }
        internal string Message { get; set; }
    }

    internal delegate void ItemsChanged(WordSetChange wsc);


    /// <summary>
    /// Набор слов для тренировки
    /// </summary>
    public class WordSet
    {
        private WordSet()
        {
            items = new Dictionary<string, DictItem>();
        }

        public static WordSet Instance()
        {
            if (instance == null)
            {
                instance = new WordSet();
            }
            return instance;
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

        public DictItem GetItem(int index)
        {
            return items.ElementAt(index).Value;
        }

        public void Add(DictItem di)
        {
            try
            {
                items.Add(di.Caption, di);
                if (itemsChanged != null)
                {
                    itemsChanged(new WordSetChange
                    { 
                        Count = items.Count, 
                        OperationName = "Append", Message = di.Caption 
                    });
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
            }
        }

        public void Delete(string caption)
        {
            items.Remove(caption);
        }

        public void DeleteCurrentItem()
        {
            items.Remove(CurrentItem.Caption);
        }

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
                if (itemsChanged != null)
                {
                    itemsChanged(new WordSetChange 
                    { 
                        Count = items.Count, 
                        OperationName = "Loaded" 
                    });
                }
            }
        }


        public void Save(string path = "")
        {
            if (String.IsNullOrEmpty(path))
                path = filePath;

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(path))
            {
                for (int i = 0; i < items.Count; i++)
                {
                    items.ElementAt(i).Value.Write(writer);
                }
            }
        }


        private ItemsChanged itemsChanged;

        private Dictionary<string, DictItem> items;
        private string filePath;
        private int selectedIndex = 0;

        private static WordSet instance = null;
    }
}
