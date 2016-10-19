using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorize.Model
{
    public delegate void ItemsLoaded(int count);
    public delegate void ItemsSaved();
    public delegate void ItemAdded();
    public delegate void ItemUpdated();
    public delegate void ItemDeleted();

    public class WordSet
    {
        private WordSet()
        {
            items = new Dictionary<string, DictItem>();
        }

        public WordSet Instance()
        {
            if (instance == null)
            {
                instance = new WordSet();
            }
            return instance;
        }

        public DictItem this[int index]
        {
            get { return items.ElementAt(index).Value; }
        }

        public int Count { get { return items.Count; } }

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
                if (itemsLoaded != null)
                {
                    itemsLoaded(items.Count);
                }
            }
        }

        public void Save(string path)
        {

        }

        public ItemsLoaded itemsLoaded;

        private Dictionary<string, DictItem> items;
        private string filePath;
        private int selectedIndex = 0;

        private static WordSet instance = null;
    }
}
