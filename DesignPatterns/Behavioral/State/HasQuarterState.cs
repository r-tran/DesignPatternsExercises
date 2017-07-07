using System;
using System.Runtime.InteropServices;

namespace DesignPatterns.Behavioral.State
{
    public class HasQuarterState : IGumballMachineState
    {
        private GumballMachine _machine;
        private Random _rand = new Random();

        public HasQuarterState(GumballMachine machine)
        {
            _machine = machine;
        }
        public void Dispense()
        {
            Console.WriteLine("No quarter dispensed");
        }

        public void Refill()
        {
            Console.WriteLine("Refilling gumballs");
            _machine.SetState(_machine.GetNoQuarterState());
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Ejecting the quarter");
            _machine.SetState(_machine.GetNoQuarterState());
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Cannot insert another quarter");
        }

        public void TurnCrank()
        {
            int num = _rand.Next(10);
            if (num == 0 && _machine.GetCount() > 0)
            {
                _machine.SetState(_machine.GetWinnerState());
            }
            else
            {
                Console.WriteLine("Turning the crank...");
                _machine.SetState(_machine.GetSoldState());
            }
        }
    }
}
