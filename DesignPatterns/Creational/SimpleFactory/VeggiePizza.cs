using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.SimpleFactory
{
    public class VeggiePizza : Pizza
    {
        public override string Prepare()
        {
            return "Preparing veggies";
        }
    }
}
