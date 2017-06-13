using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class FlyWithWings : IFlyBehavior
    {
        public string Fly()
        {
            return "I can fly!";
        }
    }

    public class FlyNoWay : IFlyBehavior
    {
        public string Fly()
        {
            return "I can't fly";
        }
    }
}
