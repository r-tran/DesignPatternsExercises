using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.CompleteDuckSim
{
    public class DuckSimulator
    {
        public void Simulate(IQuackable quackable)
        {
            quackable.Quack();
        }
    }
}
