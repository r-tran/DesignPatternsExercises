using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class Whip : ICondimentDecorator
    {
        private IBeverage _beverage;

        public Whip(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string DecoratorDescription
        {
            get
            {
                return "I am a whip decorator";
            }
        }

        public string Description
        {
            get
            {
                return _beverage.Description + " + Whip";
            }
        }

        public float Cost()
        {
            return _beverage.Cost() + 1.00f;
        }
    }
}
