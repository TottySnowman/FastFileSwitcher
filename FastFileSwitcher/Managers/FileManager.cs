using FastFileSwitcher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFileSwitcher.Managers
{
    public class FileManager
    {
        private static readonly object _lock = new object();
        private static FileManager _instance;
        private readonly List<File> _items = new List<File>();
        private FileManager()
        {
        }
        public static FileManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new FileManager();
                    }
                    return _instance;
                }
            }
        }

        public void AddItem(File item)
        {
            lock (_lock)
            {
                _items.Add(item);
            }
        }

        public IEnumerable<File> GetItems()
        {
            lock (_lock)
            {
                return new List<File>(_items);
            }
        }

        public void RemoveFile(int slot)
        {
            lock (_lock)
            {
                _items.RemoveAt(slot);
            }
        }
        public void ResetList()
        {
            lock (_lock)
            {
                _items.Clear();
            }
        }
    }
}
