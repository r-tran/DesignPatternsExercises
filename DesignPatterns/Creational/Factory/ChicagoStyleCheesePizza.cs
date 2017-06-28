using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        internal ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Cheese Pizza";
            Dough = "Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";
        }

        public override string Prepare()
        {
            return "Preparing Chicago Style Cheese Pizza";
        }
    }
}
