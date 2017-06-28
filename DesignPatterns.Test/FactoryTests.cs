using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Creational.Factory;

namespace DesignPatterns.Test
{
    [TestClass]
    public class FactoryTests
    {
        [TestMethod]
        public void PizzaStoreFactories_CreateProducts()
        {
            PizzaStore nyStore = new NewYorkPizzaStore();
            Pizza nyPizza = nyStore.OrderPizza("Cheese");
            PizzaStore chicagoStore = new ChicagoPizzaStore();
            Pizza chiPizza = chicagoStore.OrderPizza("Cheese");

            Assert.AreEqual("Thin Crust Dough", nyPizza.Dough);
            Assert.AreEqual("New York Style Cheese Pizza", nyPizza.Name);
            Assert.AreEqual("Marinara Sauce", nyPizza.Sauce);
            Assert.AreEqual("Thick Crust Dough", chiPizza.Dough);
            Assert.AreEqual("Chicago Style Cheese Pizza", chiPizza.Name);
            Assert.AreEqual("Plum Tomato Sauce", chiPizza.Sauce);
        }
    }
}
