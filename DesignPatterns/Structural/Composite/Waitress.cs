using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Waitress
    {
        private MenuComponent _allMenus; 
        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void Print()
        {
            _allMenus.Print();
        }
    }
}
