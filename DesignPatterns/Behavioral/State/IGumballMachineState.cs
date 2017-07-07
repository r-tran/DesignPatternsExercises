using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public interface IGumballMachineState
    {
        void InsertQuarter();

        void EjectQuarter();

        void TurnCrank();

        void Dispense();

        void Refill();
    }
}
