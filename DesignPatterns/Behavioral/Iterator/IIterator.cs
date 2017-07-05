using System;
using System.Collections.Generic;
namespace DesignPatterns.Behavioral.Iterator
{
    public interface IIterator
    {
        bool HasNext();

        object Next();

        void Remove();
    }
}
