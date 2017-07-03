using System;

namespace DesignPatterns.Structural.Facade
{
    public class TheaterLights
    {
        internal void Dim()
        {
            Console.WriteLine("Theater lights dimmed");
        }

        internal void On()
        {
            Console.WriteLine("Theater lights on");
        }
    }
}