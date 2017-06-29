using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class RemoteControl
    {
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;
        private ICommand _undoCommand; 
        private const int NumberOfSlots = 7;

        public RemoteControl()
        {
            _onCommands = new ICommand[NumberOfSlots];
            _offCommands = new ICommand[NumberOfSlots];

            for (int i = 0; i < NumberOfSlots; i++)
            {
                _onCommands[i] = new NoCommand();
                _offCommands[i] = new NoCommand();
            }

            _undoCommand = new NoCommand();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < NumberOfSlots; i++)
            {
                sb.AppendLine(i + " ..."+ " On: " + _onCommands[i].GetType().Name + " Off: " + _offCommands[i].GetType().Name);       
            }

            return sb.ToString();
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void ClickButtonOn(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void ClickButtonOff(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonClick()
        {
            _undoCommand.Undo();
        }
    }
}
