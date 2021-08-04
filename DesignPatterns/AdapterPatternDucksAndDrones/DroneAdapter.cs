using System;
using AdapterPatternDucksAndDrones.Interfaces;

namespace AdapterPatternDucksAndDrones
{
    public class DroneAdapter: IDuck
    {
        private readonly IDrone _drone;

        public DroneAdapter(IDrone drone)
        {
            _drone = drone;
        }
        public void Display()
        {
            _drone.Display();
        }

        public void Quack()
        {
            _drone.Beep();
        }

        public void Fly()
        {
            _drone.SpinRotors();
            _drone.TakeOff();
            Console.WriteLine("Drone is flying...");
        }

        public void Swim()
        {
            Console.WriteLine("I can't swim, but I can fly on surface :)");
            _drone.SpinRotors();
            _drone.TakeOff();
        }
    }
}