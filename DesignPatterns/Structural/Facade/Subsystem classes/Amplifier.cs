using System;

namespace DesignPatterns.Structural.Facade
{
    public class Amplifier
    {
        internal void On()
        {
            Console.WriteLine("Turning amp on");
        }

        internal void SetDvd(DvdPlayer _dvd)
        {
            Console.WriteLine("Amp set the dvd player");
        }

        internal void SetSurroundSound()
        {
            Console.WriteLine("Amp set surround sound");
        }

        internal void SetVolume(int v)
        {
            Console.WriteLine($"Amp set volume to {v}");
        }

        internal void Off()
        {
            Console.WriteLine("Set amp to off");
        }
    }
}