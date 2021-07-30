using System;
using StrategyPatternDucks.Interfaces;

namespace StrategyPatternDucks
{
    internal class Squeak: IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeak Squeak...");
        }
    }
}