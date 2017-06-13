using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Behavioral.Strategy;

namespace DesignPatterns.Test
{
    [TestClass]
    public class StrategyTests
    {
        [TestMethod]
        public void Duck_Behaviors_CanChangeBehaviorAtRuntime()
        {
            Duck mallard = new MallardDuck();
            mallard.Display();

            Assert.AreEqual("Quack!", mallard.Quack());
            Assert.AreEqual("I can fly!", mallard.Fly());

            mallard.SetQuackBehavior(new MuteQuack());
            mallard.SetFlyBehavior(new FlyNoWay());

            Assert.AreEqual("<silence>", mallard.Quack());
            Assert.AreEqual("I can't fly", mallard.Fly());
        }
    }
}
