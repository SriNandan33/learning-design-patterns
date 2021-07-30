using System;

namespace StrategyPatternDucks
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