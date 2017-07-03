using System;

namespace DesignPatterns.Structural.Facade
{
    public class PopcornPopper
    {
        internal void On()
        {
            Console.WriteLine("Popcorn popper set to on");
        }

        internal void Pop()
        {
            Console.WriteLine("Pop pop pop!");
        }

        internal void Off()
        {
            Console.WriteLine("Popcorn popper set to off");
        }
    }
}