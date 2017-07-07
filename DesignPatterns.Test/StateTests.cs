using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Behavioral.State;

namespace DesignPatterns.Test
{
    [TestClass]
    public class StateTests
    {
        //Not really a test, illustrate state changes that are encapsulated
        [TestMethod]
        public void State_GumballMachineTraversal()
        {
            GumballMachine machine = new GumballMachine(1);
            machine.InsertQuarter();
            machine.EjectQuarter();
            machine.InsertQuarter();
            machine.TurnCrank();
            machine.InsertQuarter();
        }

        [TestMethod]
        public void State_GumballMachineRefill()
        {
            GumballMachine machine = new GumballMachine(1);
            machine.InsertQuarter();
            machine.EjectQuarter();
            machine.InsertQuarter();
            machine.TurnCrank();
            machine.Refill(10);
            machine.InsertQuarter();
            Assert.AreEqual(10, machine.GetCount());
        }

        //Not really a test, illustrate state changes that are encapsulatedB
        [TestMethod]
        public void State_GumballMachineWinnerState()
        {
            GumballMachine machine = new GumballMachine(10);
            machine.InsertQuarter();
            machine.TurnCrank();

            machine.InsertQuarter();
            machine.TurnCrank();

            machine.InsertQuarter();
            machine.TurnCrank();

            machine.InsertQuarter();
            machine.TurnCrank();

            machine.InsertQuarter();
            machine.TurnCrank();

            machine.InsertQuarter();
            machine.TurnCrank();

            machine.InsertQuarter();
            machine.TurnCrank();

            machine.InsertQuarter();
            machine.TurnCrank();

            machine.InsertQuarter();
            machine.TurnCrank();

            machine.InsertQuarter();
            machine.TurnCrank();            
        }
    }
}
