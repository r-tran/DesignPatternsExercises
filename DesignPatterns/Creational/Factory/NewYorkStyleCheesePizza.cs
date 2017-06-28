using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public class NewYorkStyleCheesePizza : Pizza
    {
        internal NewYorkStyleCheesePizza()
        {
            Name = "New York Style Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
        }

        public override string Prepare()
        {
            return "Preparing New York Style Cheese Pizza";
        }
    }
}
