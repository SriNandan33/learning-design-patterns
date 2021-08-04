using System;
using AdapterPatternDucksAndDrones.Interfaces;

namespace AdapterPatternDucksAndDrones
{
    internal class MuteQuack: IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Can't Quack");
        }
    }
}