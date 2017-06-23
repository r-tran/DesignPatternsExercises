using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class Soy : ICondimentDecorator
    {
        private IBeverage _beverage;

        public Soy(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string DecoratorDescription
        {
            get
            {
                return "I am a soy decorator";
            }
        }

        public string Description
        {
            get
            {
                return _beverage.Description + " + Soy";
            }
        }

        public float Cost()
        {
            return _beverage.Cost() + 5.00f;
        }
    }
}
