using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DesignPatterns.Behavioral.State
{
    public class NoQuarterState : IGumballMachineState
    {
        private GumballMachine _machine; 

        public NoQuarterState(GumballMachine machine)
        {
            _machine = machine;
        }
            
        public void InsertQuarter()
        {
            Console.WriteLine("Inserting a quarter");
            _machine.SetState(_machine.GetHasQuarterState());
        }

        public void EjectQuarter()
        {
            Console.WriteLine("No quarter to eject");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turned crank and nothing happened");
        }

        public void Dispense()
        {
            Console.WriteLine("Nothing was dispensed");
        }

        public void Refill()
        {
            Console.WriteLine("Refilling gumballs");
            _machine.SetState(_machine.GetNoQuarterState());
        }
    }
}
