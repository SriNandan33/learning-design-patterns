using System;
using AdapterPatternDucksAndDrones.Interfaces;

namespace AdapterPatternDucksAndDrones
{
    internal class FlyNoWay: IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Can't Fly");
        }
    }
}