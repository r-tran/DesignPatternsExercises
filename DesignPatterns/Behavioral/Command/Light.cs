using System;

namespace DesignPatterns.Behavioral.Command
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light switched on!");
        }

        public void Off()
        {
            Console.WriteLine("Light switched off");
        }
    }
}