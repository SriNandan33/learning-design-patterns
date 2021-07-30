using System;

namespace StrategyPatternDucks
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Duck Simulator\n");

            var mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.Swim();
            mallardDuck.Fly();
            mallardDuck.Quack();

            var redHeadDuck = new RedHeadDuck();
            redHeadDuck.Display();
            redHeadDuck.Swim();
            redHeadDuck.Fly();
            redHeadDuck.Quack();

            var rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.Swim();
            rubberDuck.Fly();
            rubberDuck.Quack();

            var decoyDuck = new DecoyDuck();
            decoyDuck.Display();
            decoyDuck.Swim();
            decoyDuck.Fly();
            decoyDuck.Quack();
            
            Console.WriteLine("Shooting redHeadDuck");
            redHeadDuck.FlyBehaviour = new FlyNoWay();
            redHeadDuck.Display();
            redHeadDuck.Swim();
            redHeadDuck.Fly();
            redHeadDuck.Quack();
            
            Console.WriteLine("\nHelping RedHead duck with Rocket");
            redHeadDuck.FlyBehaviour = new FlyWithRocket();
            redHeadDuck.Display();
            redHeadDuck.Swim();
            redHeadDuck.Fly();
            redHeadDuck.Quack();
        }
    }
}