using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class Espresso : IBeverage
    {
        public string Description
        {
            get
            {
                return "Espresso";
            }            
        }

        public float Cost()
        {
            return 2.50f; 
        }
    }
}
