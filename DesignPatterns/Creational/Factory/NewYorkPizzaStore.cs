using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public class NewYorkPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "Cheese")
            {
                pizza = new NewYorkStyleCheesePizza();
            }
            else if (type == "Clam")
            {
                // Create New York Style Clam Pizza Product Here
            }
            else if (type == "Pepperoni")
            {
                // Create New York Style Pepperoni Pizza Product Here
            }
            else if (type == "Veggie")
            {
                // Create New York Style Veggie Pizza Product Here
            }

            return pizza;
        }
    }
}
