using System;
using AdapterPatternDucksAndDrones.Interfaces;

namespace AdapterPatternDucksAndDrones
{
    internal class Squeak: IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeak Squeak...");
        }
    }
}