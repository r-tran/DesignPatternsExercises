using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class PancakeHouseIterator : IIterator
    {
        private List<MenuItem> _menu;
        private int _index = 0;

        public PancakeHouseIterator(List<MenuItem> menu)
        {
            _menu = menu;
        }

        public bool HasNext()
        {
            if (_index >= _menu.Count)
                return false;
            return true; 
        }

        public object Next()
        {
            return _menu.ElementAt(_index++);            
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
