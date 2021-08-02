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
                new RedHeadDuck(),
                new MallardDuck(),
                new RubberDuck(),
                new DecoyDuck()
            };

            foreach(var duck in ducks)
            {
                Simulate(duck);
            }
            
            Console.WriteLine("\nShooting redHeadDuck");
            var redHeadDuck = ducks.First();
            redHeadDuck.FlyBehaviour = new FlyNoWay();
            Simulate(redHeadDuck);
            
            Console.WriteLine("\nHelping RedHead duck with Rocket");
            redHeadDuck.FlyBehaviour = new FlyWithRocket();
            Simulate(redHeadDuck);
        }
    }
}