﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public interface IBeverage
    {
        string Description { get; }

        float Cost();       
    }
}
