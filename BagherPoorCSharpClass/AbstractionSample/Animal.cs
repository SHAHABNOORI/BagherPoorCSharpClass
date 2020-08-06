using System;

namespace AbstractionSample
{
    public abstract class Animal
    {
        public abstract void AnimalSound();

        public void Sleep()
        {
            Console.WriteLine("Zzzz");
        }
    }
}