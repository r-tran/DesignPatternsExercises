using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Abstract_Factory
{
    public class NewYorkPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (type == "Cheese")
            {                
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "New York Cheese Pizza";
            }
            else if (type == "Clam")
            {                
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "New York Clam Pizza";
            }
            else if (type == "Pepperoni")
            {
                // Create Pepperoni Pizza Product Here
            }
            else if (type == "Veggie")
            {
                // Create Veggie Pizza Product Here
            }

            return pizza;
        }
    }
}
