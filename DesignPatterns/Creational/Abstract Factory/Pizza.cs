using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Abstract_Factory
{
    public abstract class Pizza
    {
        public string Name { get; set; }

        public Dough Dough { get; set; }

        public Sauce Sauce { get; set; }

        public Cheese Cheese { get; set; }

        public Pepperoni Pepperoni { get; set; }

        public Clam Clam { get; set; }

        public Veggies[] Veggies;

        public abstract void Prepare();

        public void Cut()
        {
            Console.WriteLine("Cutting pizza");
        }

        public void Box()
        {
            Console.WriteLine("Boxing pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Baking pizza");
        }
    }
}
