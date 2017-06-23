using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class Mocha : ICondimentDecorator
    {
        private IBeverage _beverage;

        public Mocha(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string DecoratorDescription
        {
            get
            {
                return "I am a mocha decorator";
            }
        }

        public string Description
        {
            get
            {
                return _beverage.Description + " + Mocha";
            }
        }

        public float Cost()
        {
            return _beverage.Cost() + 2.00f;
        }
    }
}
