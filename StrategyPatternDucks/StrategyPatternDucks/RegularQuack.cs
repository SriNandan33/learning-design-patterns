using System;
using StrategyPatternDucks.Interfaces;

namespace StrategyPatternDucks
{
    internal class RegularQuack: IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack...");
        }
    }
}