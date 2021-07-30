using System;
using StrategyPatternDucks.Interfaces;

namespace StrategyPatternDucks
{
    internal class FlyWithWings: IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flying with wings");
        }
    }
}