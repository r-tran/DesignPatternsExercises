using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.CompleteDuckSim
{
    public class GooseAdapter : IQuackable
    {
        private Goose _goose;
        private readonly IQuackObservable _quackObservable;

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
            _quackObservable = new QuackObservable(this);
        }

        public void NotifyObservers()
        {
            _quackObservable.NotifyObservers();
        }

        public void Quack()
        {
            _goose.Honk();
            NotifyObservers();
        }

        public void RegisterObservers(IQuackObserver observer)
        {
            _quackObservable.RegisterObservers(observer);
        }
    }
}
