using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class LabDoor : IDoor
    {
        public void CloseDoor()
        {
            Console.WriteLine("Closing the lab door!");
        }

        public void OpenDoor()
        {
            Console.WriteLine("Opening the lab door");
        }
    }
}
