using System;

namespace StrategyPatternDucks
{
    internal class RedHeadDuck: Duck
    {
        public RedHeadDuck()
        {
            FlyBehaviour = new FlyWithWings();
            QuackBehaviour = new RegularQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I am ReadHead Duck");
        }
    }
}