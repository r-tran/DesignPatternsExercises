using System;

namespace DesignPatterns.Behavioral.Iterator
{
    public class DinerMenu : IMenu
    {
        public const int MAXITEMS = 6;
        private int numberOfItems = 0;
        private MenuItem[] _menuItems; 

        public DinerMenu()
        {
            _menuItems = new MenuItem[MAXITEMS];
            AddItem("Lunch Item 1", "Lunch Description", true, 2.99);
            AddItem("Lunch Item 2", "Lunch Description", false, 3.99);
            AddItem("Lunch Item 3", "Lunch Description", false, 4.99);
            AddItem("Lunch Item 4", "Lunch Description", false, 5.99);
        }

        private void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem item = new MenuItem(name, description, vegetarian, price);
            if (numberOfItems >= MAXITEMS)
            {
                Console.WriteLine("Sorry, menu is full!");
            }
            else
            {
                _menuItems[numberOfItems] = item;
                numberOfItems++;
            }
        }

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }
    }
}
