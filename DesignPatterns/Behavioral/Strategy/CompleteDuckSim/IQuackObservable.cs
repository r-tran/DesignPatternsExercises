using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.CompleteDuckSim
{
    public interface IQuackObservable
    {
        void NotifyObservers();

        void RegisterObservers(IQuackObserver observer);
    }
}
