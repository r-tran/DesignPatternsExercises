using System;

namespace DesignPatterns.Structural.Facade
{
    public class Projector
    {
        internal void On()
        {
            Console.WriteLine("Turning projector on");
        }

        internal void WideScreenMode()
        {
            Console.WriteLine("Set projector to widescreen mode");
        }

        internal void Off()
        {
            Console.WriteLine("Turning projector off");
        }
    }
}