using System;
using StrategyPatternDucks.Interfaces;

namespace StrategyPatternDucks
{
    internal class MuteQuack: IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Can't Quack");
        }
    }
}