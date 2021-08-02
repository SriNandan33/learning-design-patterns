using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPatternDucks
{
    internal static class Program
    {
        private static void Simulate(Duck duck){
            duck.Display();
            duck.Swim();
            duck.Fly();
            duck.Quack();
        }
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Duck Simulator\n");
            var ducks = new List<Duck>
            {
                new MallardDuck(),
                new RedHeadDuck(),
                new RubberDuck(),
                new DecoyDuck()
            };

            foreach(var duck in ducks)
            {
                Simulate(duck);
            }
            
            Console.WriteLine("\nShooting a duck");
            var woundedDuck = ducks.First();
            woundedDuck.FlyBehaviour = new FlyNoWay();
            Simulate(woundedDuck);
            
            Console.WriteLine("\nHelping the duck to fly with Rocket");
            woundedDuck.FlyBehaviour = new FlyWithRocket();
            Simulate(woundedDuck);
        }
    }
}