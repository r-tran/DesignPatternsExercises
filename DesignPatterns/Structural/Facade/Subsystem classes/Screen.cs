using System;

namespace DesignPatterns.Structural.Facade
{
    public class Screen
    {
        internal void Down()
        {
            Console.WriteLine("Moving screen down");
        }

        internal void Up()
        {
            Console.WriteLine("Moving screen up");
        }
    }
}