using System;
using AdapterPatternDucksAndDrones.Interfaces;

namespace AdapterPatternDucksAndDrones
{
    internal class RegularQuack: IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack...");
        }
    }
}