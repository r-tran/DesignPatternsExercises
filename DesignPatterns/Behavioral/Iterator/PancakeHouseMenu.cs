using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class PancakeHouseMenu : IMenu
    {
        private List<MenuItem> _menuItems;
		public PancakeHouseMenu()
        {
            _menuItems = new List<MenuItem>();
            AddItem("Breakfast Item 1", "Breakfast Description", true, 2.99);
            AddItem("Breakfast Item 2", "Breakfast Description", false, 3.99);
            AddItem("Breakfast Item 3", "Breakfast Description", false, 4.99);
            AddItem("Breakfast Item 4", "Breakfast Description", false, 5.99);
        }

        private void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem item = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(item);
        }

        public IIterator CreateIterator()
        {
            return new PancakeHouseIterator(_menuItems);
        }
    }
}
