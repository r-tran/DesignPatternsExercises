using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class Milk : ICondimentDecorator
    {
        private IBeverage _beverage;

        public Milk(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string DecoratorDescription
        {
            get
            {
                return "I am a milk decorator";
            }
        }

        public string Description
        {
            get
            {
                return _beverage.Description + " + Milk";
            }
        }

        public float Cost()
        {
            return _beverage.Cost() + 1.25f;
        }
    }
}
