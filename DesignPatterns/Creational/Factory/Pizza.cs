using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public abstract class Pizza
    {
        public string Dough { get; protected set; }

        public string Name { get; protected set; }

        public string Sauce { get; protected set; }

        protected List<string> _toppings = new List<string>();


        public abstract string Prepare();

        public string Bake()
        {
            return "Baking pizza";
        }
        public string Cut()
        {
            return "Cutting pizza";
        }

        public string Box()
        {
            return "Boxing pizza";
        }
    }   
}
