using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class DarkRoast : IBeverage
    {
        public string Description
        {
            get
            {
                return "Dark Roast Coffee";
            }            
        }

        public float Cost()
        {
            return 1.75f;
        }
    }
}
