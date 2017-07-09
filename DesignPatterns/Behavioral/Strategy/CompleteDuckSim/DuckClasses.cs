using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.CompleteDuckSim
{
    public class MallardDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }

    public class RedheadDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }

    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Kwak");
        }
    }

    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
