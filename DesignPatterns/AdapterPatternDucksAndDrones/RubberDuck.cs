using System;

namespace AdapterPatternDucksAndDrones
{
    internal class RubberDuck: Duck
    {
        public RubberDuck()
        {
            FlyBehaviour = new FlyNoWay();
            QuackBehaviour = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("I am RubberDuck");
        }
    }
}