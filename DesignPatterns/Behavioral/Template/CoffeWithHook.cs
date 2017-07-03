using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Template
{
    public class CoffeWithHook : CaffeineBeverageWithHook
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding in milk and cream");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }
        public override bool CustomerWantsCondiments()
        {
            return false;
        }
    }
}
