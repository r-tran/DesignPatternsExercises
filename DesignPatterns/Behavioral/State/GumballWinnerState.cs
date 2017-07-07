using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class GumballWinnerState : IGumballMachineState
    {
        private GumballMachine _machine;

        public GumballWinnerState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Cannot insert quarter in winner state");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Cannot eject quarter in winner state");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning the crank does nothing in winner state");
        }

        public void Dispense()
        {
            _machine.ReleaseBall();
            if (_machine.GetCount() == 0)
                _machine.SetState(_machine.GetSoldOutState());
            else
            {
                _machine.ReleaseBall();
                Console.WriteLine("Congratulations! You are a winner");
                if (_machine.GetCount() == 0)
                {
                    _machine.SetState(_machine.GetSoldOutState());
                    Console.WriteLine("Sold out of gumballs");
                }                    
                else                
                    _machine.SetState(_machine.GetNoQuarterState());
            }
        }

        public void Refill()
        {
            Console.WriteLine("Refill does nothing in this intermediate state");
        }
    }
}
