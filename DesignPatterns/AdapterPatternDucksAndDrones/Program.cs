using System;
using System.Collections.Generic;
using System.Linq;
using AdapterPatternDucksAndDrones.Interfaces;

namespace AdapterPatternDucksAndDrones
{
    internal static class Program
    {
        private static void Simulate(IDuck duck){
            duck.Display();
            duck.Swim();
            duck.Fly();
            duck.Quack();
        }
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Duck Simulator\n");
            var ducks = new List<IDuck>
            {
                new MallardDuck(),
                new DroneAdapter(new Drone())
            };

            foreach(var duck in ducks)
            {
                Simulate(duck);
            }
        }
    }
}