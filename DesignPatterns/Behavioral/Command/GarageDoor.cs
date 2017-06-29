using System;

namespace DesignPatterns.Behavioral.Command
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Opening garage door.");
        }
        public void Down()
        {
            Console.WriteLine("Closing garage door.");
        }
    }
}