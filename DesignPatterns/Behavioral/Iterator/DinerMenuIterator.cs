using System;

namespace DesignPatterns.Behavioral.Iterator
{
    public class DinerMenuIterator : IIterator
    {
        private MenuItem[] _menu;
        private int _index = 0;

        public DinerMenuIterator(MenuItem[] menu)
        {
            _menu = menu;
        }

        public bool HasNext()
        {
            if (_index >= _menu.Length || _menu[_index] == null)
            {
                return false; 
            }

            return true;
        }

        public object Next()
        {
            return _menu[_index++];                        
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
