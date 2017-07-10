using System.Collections.Generic;


namespace DesignPatterns.Behavioral.Strategy.CompleteDuckSim
{
    public class Flock : IQuackable
    {
        private readonly List<IQuackable> _quackables;
        private readonly QuackObservable _quackObservable;

        public Flock()
        {
            _quackables = new List<IQuackable>();
            _quackObservable = new QuackObservable(this);
        }

        public void Add(IQuackable quackable)
        {
            _quackables.Add(quackable);            
        }

        public void Quack()
        {
            foreach (var quackable in _quackables)
            {
                quackable.Quack();
            }

            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var quackable in _quackables)
            {
                quackable.NotifyObservers();
            }

            _quackObservable.NotifyObservers();
        }

        public void RegisterObservers(IQuackObserver observer)
        {
            foreach (var quackable in _quackables)
            {
                quackable.RegisterObservers(observer);
            }

            _quackObservable.RegisterObservers(observer);
        }
    }
}
