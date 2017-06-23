using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class SimpleCoffee : IBeverage
    {
        public string Description
        {
            get
            {
                return "Simple Black Coffee";
            }
        }

        public float Cost()
        {
            return .70f;
        }
    }
}
