using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public abstract class Duck
    {
        protected IQuackBehavior _quackBehavior;
        protected IFlyBehavior _flyBehavior;
        
        public void Swim()
        {
            Console.WriteLine("All ducks can swim.");
        }

        public string Quack()
        {
            return _quackBehavior.Quack();
        }

        public string Fly()
        {
            return _flyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyBehavior behavior)
        {
            _flyBehavior = behavior;
        }

        public void SetQuackBehavior(IQuackBehavior behavior)
        {
            _quackBehavior = behavior;
        }

        public abstract void Display();             
    }
}
