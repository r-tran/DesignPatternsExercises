using System;

namespace DesignPatterns.Behavioral.Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new QuackNormal();      
        }

        public override void Display()
        {
            Console.WriteLine("I'm a mallard duck");
        }
    }

    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new QuackNormal();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a redhead duck");
        }
    }

    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a rubber duck");
        }
    }

    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a decoy duck");
        }
    }
}
