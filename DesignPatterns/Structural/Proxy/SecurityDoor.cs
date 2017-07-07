using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class SecurityDoor : IDoor
    {
        private IDoor _door;
        private string _password;

        public SecurityDoor(IDoor door)
        {
            _door = door;
            _password = "none";
        }

        public void SetPassword(string password)
        {
            _password = password;
        }

        public void CloseDoor()
        {
            _door.CloseDoor();
        }

        public void OpenDoor()
        {
            if (_password == "S3cR3T!")
                _door.OpenDoor();
            else
                Console.WriteLine("Locked.");
        }
    }
}
