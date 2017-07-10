using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.CompleteDuckSim
{
    class QuackObservable : IQuackObservable
    {
        private List<IQuackObserver> _observers;
        private IQuackable _duck;

        public QuackObservable(IQuackable duck)
        {
            _observers = new List<IQuackObserver>();
            _duck = duck;
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_duck);
            }
        }

        public void RegisterObservers(IQuackObserver observer)
        {
            _observers.Add(observer);
        }
    }
}
