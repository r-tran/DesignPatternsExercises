using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.CompleteDuckSim
{
    public class DuckCounterFactory : IDuckFactory
    {
        public IQuackable CreateMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public IQuackable CreateRedheadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public IQuackable CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public IQuackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
