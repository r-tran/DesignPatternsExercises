using System;

namespace DesignPatterns.Behavioral.State
{
    public class GumballSoldState : IGumballMachineState
    {
        private GumballMachine _machine;

        public GumballSoldState(GumballMachine machine)
        {
            _machine = machine;
        }
        public void InsertQuarter()
        {
            Console.WriteLine("Cannot insert a quarter in sold state");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Cannot eject quarter, already sold");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Crank turned again, but does nothing");
        }

        public void Dispense()
        {
            _machine.ReleaseBall();

            if (_machine.GetCount() > 0)
            {
                _machine.SetState(_machine.GetNoQuarterState());                    
            }
            else
            {
                Console.WriteLine("Sold out of gumballs");
                _machine.SetState(_machine.GetSoldOutState());
            }
        }

        public void Refill()
        {
            Console.WriteLine("Refilling gumballs");
            _machine.SetState(_machine.GetNoQuarterState());
        }
    }
}
