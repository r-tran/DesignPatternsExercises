using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Behavioral.Strategy.CompleteDuckSim;

namespace DesignPatterns.Test
{
    [TestClass]
    public class CompoundPatternsTests
    {
        // Not really a test, demonstrate strategy
        [TestMethod]
        public void Compound_Strategy_Behavior()
        {
            DuckSimulator duckSim = new DuckSimulator();
            IQuackable duck1 = new MallardDuck();
            IQuackable duck2 = new DuckCall();
            duckSim.Simulate(duck1);
            duckSim.Simulate(duck2);
        }

        [TestMethod]
        public void Compound_Adapter_Behavior()
        {
            DuckSimulator duckSim = new DuckSimulator();
            IQuackable duck1 = new RubberDuck();
            Goose goose = new Goose();
            IQuackable gooseAdapter = new GooseAdapter(goose);

            duckSim.Simulate(duck1);
            duckSim.Simulate(gooseAdapter);
        }

        [TestMethod]
        public void Compound_Decorator_Behavior()
        {
            DuckSimulator duckSim = new DuckSimulator();
            IQuackable duck1 = new QuackCounter(new RubberDuck());
            Goose goose = new Goose();
            IQuackable gooseAdapter = new QuackCounter(new GooseAdapter(goose));

            duckSim.Simulate(duck1);
            duckSim.Simulate(gooseAdapter);
            
            Assert.AreEqual(2, QuackCounter.GetQuackCount());
        }
    }
}
