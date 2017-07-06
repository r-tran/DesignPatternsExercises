using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Structural.Composite;

namespace DesignPatterns.Test
{
    // Not really a test, demonstration of composite
    [TestClass]
    public class CompositeTests
    {
        [TestMethod]
        public void Composite_TreeStructure()
        {
            MenuComponent pankcakeHouseMenu = new Menu("Pancake House Menu", "breakfast");
            MenuComponent dinerMenu = new Menu("Diner menu", "lunch");
            MenuComponent cafeMenu = new Menu("Cafe menu", "dinner");
            MenuComponent dessertMenu = new Menu("Dessert menu", "Dessert, of course!");

            MenuComponent allMenus = new Menu("ALL MENUS", "All the menus combined");

            allMenus.Add(pankcakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);
            dinerMenu.Add(dessertMenu);
            dinerMenu.Add(new MenuItem("Lunch Item 4", "Lunch Description", false, 5.99));
            dessertMenu.Add(new MenuItem("Dessert Item", "Dessert Description", false, 20.99));
            
            Waitress waitress = new Waitress(allMenus);
            waitress.Print();
        }     
    }
}
