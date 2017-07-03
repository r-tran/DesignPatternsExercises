using System;

namespace DesignPatterns.Structural.Facade
{
    public class DvdPlayer
    {
        internal void On()
        {
            Console.WriteLine("Dvd player on");
        }

        internal void Play(string movie)
        {
            Console.WriteLine($"Dvd playing {movie}");
        }

        internal void Stop()
        {
            Console.WriteLine("Dvd stop");
        }

        internal void Eject()
        {
            Console.WriteLine("Dvd eject");
        }

        internal void Off()
        {
            Console.WriteLine("Dvd off");
        }
    }
}