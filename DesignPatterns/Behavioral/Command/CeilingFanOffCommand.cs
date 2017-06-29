﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class CeilingFanOffCommand : ICommand
    {
        private CeilingFan _fan;
        private int _prevCommand;

        public CeilingFanOffCommand(CeilingFan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _prevCommand = _fan.Speed;
            _fan.Off();
        }

        public void Undo()
        {
            if (_prevCommand == _fan.HIGH)
            {
                _fan.High();
            }
            else if (_prevCommand == _fan.MEDIUM)
            {
                _fan.Medium();
            }
            else if (_prevCommand == _fan.LOW)
            {
                _fan.Low();
            }
            else if (_prevCommand == _fan.OFF)
            {
                _fan.Off();
            }
        }
    }
}
