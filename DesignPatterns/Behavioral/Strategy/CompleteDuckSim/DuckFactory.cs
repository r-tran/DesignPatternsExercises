using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.CompleteDuckSim
{
    public class DuckFactory : IDuckFactory
    {
        public IQuackable CreateMallardDuck()
        {
            return new MallardDuck();
        }

        public IQuackable CreateRedheadDuck()
        {
            return new RedheadDuck();
        }

        public IQuackable CreateDuckCall()
        {
            return new DuckCall();
        }

        public IQuackable CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }
}
