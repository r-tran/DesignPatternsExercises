﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.CompleteDuckSim
{
    public class QuackCounter : IQuackable
    {
        private IQuackable _quackable;
        private static int _quackCounter;

        public QuackCounter(IQuackable quackable)
        {
            _quackable = quackable;
            _quackCounter = 0;
        }

        public void Quack()
        {
            _quackable.Quack();
            _quackCounter++;
        }

        public static int GetQuackCount()
        {
            return _quackCounter;
        }
    }
}
