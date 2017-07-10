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

        [TestMethod]
        public void Compound_AbstractFactory()
        {            
            IDuckFactory counterFactory = new DuckCounterFactory();
            IDuckFactory duckFactory = new DuckFactory();
            IQuackable duck1 = counterFactory.CreateDuckCall();
            IQuackable duck2 = counterFactory.CreateRubberDuck();
            IQuackable duck3 = duckFactory.CreateMallardDuck();

            duck1.Quack();
            duck2.Quack();
            duck3.Quack();

            Assert.AreEqual(2, QuackCounter.GetQuackCount());
        }

        [TestMethod]
        public void Compound_Composite()
        {
            DuckSimulator sim = new DuckSimulator();

            Flock flockDucks = new Flock();
            IDuckFactory duckFactory = new DuckFactory();            
            flockDucks.Add(duckFactory.CreateMallardDuck());
            flockDucks.Add(duckFactory.CreateMallardDuck());
            flockDucks.Add(duckFactory.CreateMallardDuck());
            flockDucks.Add(duckFactory.CreateMallardDuck());            
            Flock flockRubberDucks = new Flock();
            flockRubberDucks.Add(duckFactory.CreateRubberDuck());
            flockRubberDucks.Add(duckFactory.CreateRubberDuck());
            flockRubberDucks.Add(duckFactory.CreateRubberDuck());
            flockDucks.Add(flockRubberDucks);

            sim.Simulate(flockDucks);
        }

        [TestMethod]
        public void Compound_Observer()
        {
            DuckSimulator sim = new DuckSimulator();            
            Flock flockDucks = new Flock();            
            IDuckFactory duckFactory = new DuckCounterFactory();

            flockDucks.Add(duckFactory.CreateMallardDuck());
            flockDucks.Add(duckFactory.CreateRubberDuck());
            flockDucks.Add(duckFactory.CreateRedheadDuck());
            flockDucks.Add(duckFactory.CreateDuckCall());
            flockDucks.Add(new GooseAdapter(new Goose()));

            flockDucks.RegisterObservers(new QuackologistObserver());

            sim.Simulate(flockDucks);  
            Assert.AreEqual(4, QuackCounter.GetQuackCount());          
        }
    }
}
