using System;
using AdapterPatternDucksAndDrones.Interfaces;

namespace AdapterPatternDucksAndDrones
{
    internal class FlyWithWings: IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flying with wings");
        }
    }
}