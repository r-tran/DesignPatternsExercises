using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "Cheese")
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (type == "Clam")
            {
                // Create Chicago Style Clam Pizza Product Here
            }
            else if (type == "Pepperoni")
            {
                // Create Chicago Style Pepperoni Pizza Product Here
            }
            else if (type == "Veggie")
            {
                // Create Chicago Style Veggie Pizza Product Here
            }

            return pizza;
        }
    }
}
