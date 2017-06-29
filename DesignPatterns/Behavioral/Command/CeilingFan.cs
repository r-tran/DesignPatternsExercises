using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class CeilingFan
    {
        public int HIGH = 3;
        public int MEDIUM = 2;
        public int LOW = 1;
        public int OFF = 0;        

        public int Speed { get; private set; }

        public void High()
        {
            Speed = HIGH;
            Console.WriteLine("Set fan to HIGH");
        }

        public void Medium()
        {
            Speed = MEDIUM;
            Console.WriteLine("Set fan to medium");
        }

        public void Low()
        {
            Speed = LOW;
            Console.WriteLine("Set fan to low");
        }

        public void Off()
        {
            Speed = OFF;
            Console.WriteLine("Set fan to off");
        }
    }
}
