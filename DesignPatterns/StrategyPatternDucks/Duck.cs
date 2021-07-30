using System;
using StrategyPatternDucks.Interfaces;

namespace StrategyPatternDucks
{
    internal abstract class Duck
    {
        public IFlyBehaviour FlyBehaviour { get; set; }
        protected IQuackBehaviour QuackBehaviour { get; set; }

        protected Duck()
        {
            
        }

        public void Fly()
        {
            FlyBehaviour.Fly();
        }

        public void Quack()
        {
            QuackBehaviour.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("I am floating on water");
        }

        public abstract void Display();
    }
}