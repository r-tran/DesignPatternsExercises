using System;

namespace DesignPatterns.Behavioral.State
{
    public class OutOfGumballsState : IGumballMachineState
    {
        private GumballMachine _machine;  

        public OutOfGumballsState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("Sold out, cannot dispense gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sold out, cannot eject quarter");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Sold out, cannot insert quarter");            
        }

        public void TurnCrank()
        {
            Console.WriteLine("Sold out, turning crank does nothing");
        }

        public void Refill()
        {
            Console.WriteLine("Refilling gumballs");
            _machine.SetState(_machine.GetNoQuarterState());
        }
    }
}
