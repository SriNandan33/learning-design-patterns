using System;
using StrategyPatternDucks.Interfaces;

namespace StrategyPatternDucks
{
    public class FlyWithRocket: IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flying with Rocket");
        }
    }
}