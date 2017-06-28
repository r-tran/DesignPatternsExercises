using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Abstract_Factory
{
    public class ClamPizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory; 

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;    
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Cheese = _ingredientFactory.CreateCheese();
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Clam = _ingredientFactory.CreateClam();
        }
    }
}
