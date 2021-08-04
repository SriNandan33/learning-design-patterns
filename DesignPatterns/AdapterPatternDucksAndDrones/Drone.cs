using System;
using AdapterPatternDucksAndDrones.Interfaces;

namespace AdapterPatternDucksAndDrones
{
    public class Drone: IDrone
    {
        public void Display()
        {
            Console.WriteLine("I am drone");
        }

        public void Beep()
        {
            Console.WriteLine("Beep Beep....");
        }

        public void SpinRotors()
        {
            Console.WriteLine("Rotors are spinning");
        }

        public void TakeOff()
        {
            Console.WriteLine("Taking off...");
        }
    }
}