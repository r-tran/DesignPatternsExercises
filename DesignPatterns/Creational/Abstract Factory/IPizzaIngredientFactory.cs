using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Abstract_Factory
{
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();

        Sauce CreateSauce();

        Cheese CreateCheese();

        Pepperoni CreatePepperoni();

        Clam CreateClam();

        Veggies[] CreateVeggie(); 
    }
}
