using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.SimpleFactory
{
    public abstract class Pizza
    {
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
