using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Template
{
    public class TeaWithHook : CaffeineBeverageWithHook
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding a slice of lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Brewing tea leaves");
        }
    }
}
