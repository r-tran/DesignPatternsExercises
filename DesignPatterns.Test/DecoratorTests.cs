using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Structural.Decorator;


namespace DesignPatterns.Test
{    
    [TestClass]
    public class DecoratorTests
    {
        [TestMethod]
        public void BeverageObjectDescription_ReturnsCorrectName()
        {
            IBeverage roast = new DarkRoast();
            Assert.AreEqual("Dark Roast Coffee", roast.Description);

            IBeverage coffee = new SimpleCoffee();
            Assert.AreEqual("Simple Black Coffee", coffee.Description);

            IBeverage espresso = new Espresso();
            Assert.AreEqual("Espresso", espresso.Description);
        }

        [TestMethod]
        public void CondimentDecorator_DecorateDescriptionIsValid()
        {
            IBeverage coffee = new SimpleCoffee();
            ICondimentDecorator drink = new Mocha(coffee);

            Assert.AreEqual("I am a mocha decorator", drink.DecoratorDescription);
        }

        [TestMethod]
        public void CondimentDecorator_DecoratesCorrectly()
        {
            IBeverage coffee = new SimpleCoffee();
            ICondimentDecorator order = new Whip(coffee);

            Assert.AreEqual("Simple Black Coffee + Whip", order.Description);
        }

        [TestMethod]
        public void CondimentDecorator_DecoratesMultipleCorrectly()
        {
            string expectedOrderName = "Simple Black Coffee + Whip + Whip + Mocha + Milk + Soy";

            IBeverage coffee = new SimpleCoffee();
            ICondimentDecorator order = new Whip(coffee);
            order = new Whip(order);
            order = new Mocha(order);
            order = new Milk(order);
            order = new Soy(order);

            Assert.AreEqual(expectedOrderName, order.Description);
        }
    }
}
