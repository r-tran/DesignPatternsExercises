using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class Waitress
    {
        private List<IMenu> _menus;

        public Waitress(List<IMenu> menus)
        {
            _menus = menus;
        }

        public void PrintMenu()
        {
            foreach (var menu in _menus)
            {
                PrintMenu(menu.CreateIterator());
            }
        }

        public void PrintMenu(IIterator menuIterator)
        {
            while (menuIterator.HasNext())
            {
                MenuItem item = (MenuItem) menuIterator.Next();
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Description);
                Console.WriteLine(item.Vegetarian);
                Console.WriteLine(item.Price);
            }
        }
    }
}
