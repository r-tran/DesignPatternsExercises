using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class QuackNormal : IQuackBehavior
    {
        public string Quack()
        {
            return "Quack!";
        }
    }

    public class Squeak : IQuackBehavior
    {
        public string Quack()
        {
            return "Squeak!";
        }
    }

    public class MuteQuack : IQuackBehavior
    {
        public string Quack()
        {
            return "<silence>";
        }
    }
}
