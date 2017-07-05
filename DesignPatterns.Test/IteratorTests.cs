using DesignPatterns.Behavioral.Iterator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DesignPatterns.Test
{
    [TestClass]
    public class IteratorTests
    {
        // Not really a test, demos the encapsulation of aggregate objets
        [TestMethod]
        public void Iterator_CollectionsDemo()
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();
            List<IMenu> menus = new List<IMenu>();
            menus.Add(pancakeHouseMenu);
            menus.Add(dinerMenu);
            Waitress waitress = new Waitress(menus);

            waitress.PrintMenu();
        }
    }
}
