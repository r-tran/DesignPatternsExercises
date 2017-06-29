using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class GarageDoorOpenCommand : ICommand
    {
        private GarageDoor _garageDoor;

        public GarageDoorOpenCommand(GarageDoor door)
        {
            _garageDoor = door;
        }

        public void Execute()
        {
            _garageDoor.Up();
        }

        public void Undo()
        {
            _garageDoor.Down();
        }
    }
}
