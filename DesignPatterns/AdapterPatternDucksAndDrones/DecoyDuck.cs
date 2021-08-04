using System;

namespace AdapterPatternDucksAndDrones
{
    internal class DecoyDuck: Duck
    {
        public DecoyDuck()
        {
            FlyBehaviour = new FlyNoWay();
            QuackBehaviour = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I am DecoyDuck");
        }
    }
}