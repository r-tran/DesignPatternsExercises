using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Behavioral.Command;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Test
{
    // Not really a test class, more of a client for the Command pattern
    [TestClass]
    public class CommandTests
    {        
        [TestMethod]
        public void RemoteControl_ToString()
        {
            RemoteControl control = new RemoteControl();
            GarageDoor door = new GarageDoor();
            Light light = new Light();
            CeilingFan fan = new CeilingFan();

            GarageDoorOpenCommand openGarageCommand = new GarageDoorOpenCommand(door);
            GarageDoorCloseCommand closeGarageCommand = new GarageDoorCloseCommand(door);
            LightOffCommand lightOffCommand = new LightOffCommand(light);
            LightOnCommand lightOnCommand = new LightOnCommand(light);
            CeilingFanHighCommand fanHighCommand = new CeilingFanHighCommand(fan);
            CeilingFanOffCommand fanOffCommand = new CeilingFanOffCommand(fan);

            control.SetCommand(0, lightOnCommand, lightOffCommand);
            control.SetCommand(1, openGarageCommand, closeGarageCommand);
            control.SetCommand(2, fanHighCommand, fanOffCommand);
            Console.WriteLine(control.ToString());
        }

        [TestMethod]
        public void RemoteControl_Undo()
        {
            RemoteControl control = new RemoteControl();
            GarageDoor door = new GarageDoor();
            Light light = new Light();
            CeilingFan fan = new CeilingFan();

            GarageDoorOpenCommand openGarageCommand = new GarageDoorOpenCommand(door);
            GarageDoorCloseCommand closeGarageCommand = new GarageDoorCloseCommand(door);
            LightOffCommand lightOffCommand = new LightOffCommand(light);
            LightOnCommand lightOnCommand = new LightOnCommand(light);
            CeilingFanHighCommand fanHighCommand = new CeilingFanHighCommand(fan);
            CeilingFanOffCommand fanOffCommand = new CeilingFanOffCommand(fan);

            control.SetCommand(0, lightOnCommand, lightOffCommand);
            control.SetCommand(1, openGarageCommand, closeGarageCommand);
            control.SetCommand(2, fanHighCommand, fanOffCommand);

            control.ClickButtonOn(0);
            control.ClickButtonOn(1);
            control.ClickButtonOff(2);
            control.UndoButtonClick();
        }

        [TestMethod]
        public void RemoteControl_Macro()
        {
            RemoteControl control = new RemoteControl();
            GarageDoor door = new GarageDoor();
            Light light = new Light();
            CeilingFan fan = new CeilingFan();

            GarageDoorOpenCommand openGarageCommand = new GarageDoorOpenCommand(door);
            GarageDoorCloseCommand closeGarageCommand = new GarageDoorCloseCommand(door);
            LightOffCommand lightOffCommand = new LightOffCommand(light);
            LightOnCommand lightOnCommand = new LightOnCommand(light);
            CeilingFanHighCommand fanHighCommand = new CeilingFanHighCommand(fan);
            CeilingFanOffCommand fanOffCommand = new CeilingFanOffCommand(fan);

            List<ICommand> onCommands = new List<ICommand>()
            {
                new GarageDoorOpenCommand(door),
                new LightOnCommand(light),
                new CeilingFanHighCommand(fan)
            };

            List<ICommand> offCommands = new List<ICommand>()
            {
                new GarageDoorCloseCommand(door),
                new LightOffCommand(light),
                new CeilingFanOffCommand(fan)
            };

            MacroCommand onMacro = new MacroCommand(onCommands);
            MacroCommand offMacro = new MacroCommand(offCommands);

            control.SetCommand(0, onMacro, offMacro);
            control.ClickButtonOn(0);
            control.ClickButtonOff(0);
            control.UndoButtonClick();
        }
    }
}
