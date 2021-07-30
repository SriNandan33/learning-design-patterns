using System;
using StrategyPatternDucks.Interfaces;

namespace StrategyPatternDucks
{
    internal class FlyNoWay: IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Can't Fly");
        }
    }
}