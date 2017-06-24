using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Creational.SimpleFactory;

namespace DesignPatterns.Test
{
    [TestClass]
    public class SimpleFactoryTests
    {
        [TestMethod]
        public void PizzaStore_OrderClamPizza()
        {
            PizzaStore store = new PizzaStore();
            Pizza pizza = store.OrderPizza("Clam");
            Assert.AreEqual("Preparing clams", pizza.Prepare());
        }

        [TestMethod]
        public void PizzaStore_OrderCheesePizza()
        {
            PizzaStore store = new PizzaStore();
            Pizza pizza = store.OrderPizza("Cheese");
            Assert.AreEqual("Preparing cheeses", pizza.Prepare());
        }

        [TestMethod]
        public void PizzaStore_OrderVeggiePizza()
        {
            PizzaStore store = new PizzaStore();
            Pizza pizza = store.OrderPizza("Veggie");
            Assert.AreEqual("Preparing veggies", pizza.Prepare());
        }

        [TestMethod]
        public void PizzaStore_OrderPepperoniPizza()
        {
            PizzaStore store = new PizzaStore();
            Pizza pizza = store.OrderPizza("Pepperoni");
            Assert.AreEqual("Preparing pepperonis", pizza.Prepare());
        }
    }
}
