using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class GarageDoorCloseCommand : ICommand
    {
        private GarageDoor _garageDoor;

        public GarageDoorCloseCommand(GarageDoor door)
        {
            _garageDoor = door;
        }

        public void Execute()
        {
            _garageDoor.Down();
        }

        public void Undo()
        {
            _garageDoor.Up();
        }
    }
}