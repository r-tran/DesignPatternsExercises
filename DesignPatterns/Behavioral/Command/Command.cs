using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class Command<T> : ICommand
    {
        private T _receiver;
        private Action<T> _doCommand;
        private Action<T> _undoCommand;

        public Command(T receiver, Action<T> doCommand, Action<T> undoCommand)
        {
            _receiver = receiver;
            _doCommand = doCommand;
            _undoCommand = undoCommand;
        }

        public void Execute()
        {
            _doCommand(_receiver);
        }

        public void Undo()
        {
            _undoCommand(_receiver);
        }
    }
}
