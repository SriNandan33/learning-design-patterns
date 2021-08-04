using System;

namespace AdapterPatternDucksAndDrones
{
    internal class MallardDuck: Duck
    {
        public MallardDuck()
        {
            FlyBehaviour = new FlyWithWings();
            QuackBehaviour = new RegularQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I am MallardDuck");
        }
    }
}