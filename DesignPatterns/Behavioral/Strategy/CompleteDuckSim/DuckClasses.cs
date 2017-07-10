using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.CompleteDuckSim
{
    public class MallardDuck : IQuackable
    {
        private readonly IQuackObservable _quackObservable;

        public MallardDuck()
        {
            _quackObservable = new QuackObservable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Quack!");
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            _quackObservable.NotifyObservers();
        }

        public void RegisterObservers(IQuackObserver observer)
        {
            _quackObservable.RegisterObservers(observer);
        }
    }

    public class RedheadDuck : IQuackable
    {
        private readonly IQuackObservable _quackObservable;

        public RedheadDuck()
        {
            _quackObservable = new QuackObservable(this);
        }

        public void NotifyObservers()
        {
            _quackObservable.NotifyObservers();
        }

        public void Quack()
        {
            Console.WriteLine("Quack!");
            NotifyObservers();
        }

        public void RegisterObservers(IQuackObserver observer)
        {
            _quackObservable.RegisterObservers(observer);
        }
    }

    public class DuckCall : IQuackable
    {
        private readonly IQuackObservable _quackObservable;

        public DuckCall()
        {
            _quackObservable = new QuackObservable(this);
        }

        public void NotifyObservers()
        {
            _quackObservable.NotifyObservers();
        }

        public void Quack()
        {
            Console.WriteLine("Kwak");
            NotifyObservers();
        }

        public void RegisterObservers(IQuackObserver observer)
        {
            _quackObservable.RegisterObservers(observer);
        }
    }

    public class RubberDuck : IQuackable
    {
        private readonly IQuackObservable _quackObservable;

        public RubberDuck()
        {
            _quackObservable = new QuackObservable(this);
        }
        public void Quack()
        {
            Console.WriteLine("Squeak");
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            _quackObservable.NotifyObservers();
        }

        public void RegisterObservers(IQuackObserver observer)
        {
            _quackObservable.RegisterObservers(observer);
        }
    }
}
