using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.CompleteDuckSim
{
    public class QuackologistObserver : IQuackObserver
    {
        public void Update(IQuackable duck)
        {
            Console.WriteLine($"Quackologist Got: {duck.GetType().Name}");            
        }
    }
}
