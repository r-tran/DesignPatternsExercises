using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Creational.Abstract_Factory;

namespace DesignPatterns.Test
{
    [TestClass]
    public class AbstractFactoryTests
    {
        [TestMethod]
        public void AbstractFactory_CheeseProductsCreated()
        {
            PizzaStore chiStore = new ChicagoPizzaStore();
            Pizza chiPizza = chiStore.OrderPizza("Cheese");

            PizzaStore nyStore = new NewYorkPizzaStore();
            Pizza nyPizza = nyStore.OrderPizza("Cheese");

            Assert.AreEqual("Chicago Cheese Pizza", chiPizza.Name);
            Assert.AreEqual("New York Cheese Pizza", nyPizza.Name);
        }

        [TestMethod]
        public void AbstractFactory_ClamProductsCreated()
        {
            PizzaStore chiStore = new ChicagoPizzaStore();
            Pizza chiPizza = chiStore.OrderPizza("Clam");

            PizzaStore nyStore = new NewYorkPizzaStore();
            Pizza nyPizza = nyStore.OrderPizza("Clam");

            Assert.AreEqual("Chicago Clam Pizza", chiPizza.Name);
            Assert.AreEqual("New York Clam Pizza", nyPizza.Name);
        }
    }
}
