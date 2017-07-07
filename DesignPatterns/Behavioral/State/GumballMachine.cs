using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class GumballMachine
    {
        private IGumballMachineState _soldOutState;
        private IGumballMachineState _noQuarterState;
        private IGumballMachineState _hasQuarterState;
        private IGumballMachineState _soldState;
        private IGumballMachineState _winnerState; 

        private IGumballMachineState _state;
        private int _gumballCount;

        public GumballMachine(int numGumballs)
        {
            _soldOutState = new OutOfGumballsState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new GumballSoldState(this);
            _winnerState = new GumballWinnerState(this);

            _gumballCount = numGumballs;
            _state = _gumballCount > 0 ? _noQuarterState : _soldOutState;
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public void ReleaseBall()
        {            
            Console.WriteLine("Releasing a gumball...");
            if (_gumballCount > 0)
                _gumballCount--;            
        }

        public void Refill(int num)
        {
            _gumballCount += num;
            _state.Refill();
        }

        public int GetCount()
        {
            return _gumballCount;
        }

        public void SetState(IGumballMachineState state)
        {
            _state = state;
        }

        public IGumballMachineState GetSoldOutState()
        {
            return _soldOutState;
        }

        public IGumballMachineState GetNoQuarterState()
        {
            return _noQuarterState;
        }

        public IGumballMachineState GetHasQuarterState()
        {
            return _hasQuarterState;
        }

        public IGumballMachineState GetSoldState()
        {
            return _soldState;
        }

        public IGumballMachineState GetWinnerState()
        {
            return _winnerState;
        }
    }
}
