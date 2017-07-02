using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class MallardDuck : IDuck
    {
        public string Fly()
        {
            return "I'm flying!";
        }

        public string Quack()
        {
            return "Quack!";
        }
    }
}
