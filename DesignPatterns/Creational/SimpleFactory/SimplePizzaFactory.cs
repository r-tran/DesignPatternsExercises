using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.SimpleFactory
{
    public class SimplePizzaFactory
    {
        public static Pizza CreatePizza(string type)
        {
            Pizza pizza = null; 

            if (type == "Cheese")
            {
                pizza = new CheezePizza();
            }
            else if (type == "Pepperoni")
            {
                pizza = new PepperoniPizza();
            }
            else if (type == "Clam")
            {
                pizza = new ClamPizza();
            }
            else if (type == "Veggie")
            {
                pizza = new VeggiePizza();
            }

            return pizza;
        }
    }
}
