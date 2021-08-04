using System;
using AdapterPatternDucksAndDrones.Interfaces;

namespace AdapterPatternDucksAndDrones
{
    public class FlyWithRocket: IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flying with Rocket");
        }
    }
}