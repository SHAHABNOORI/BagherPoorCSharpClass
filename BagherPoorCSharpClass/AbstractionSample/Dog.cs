using System;

namespace AbstractionSample
{
    public class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Vagh Vagh");
        }

        public void ProtectYou()
        {
            Console.WriteLine("Dog Will Protect You");
        }

        public new void Sleep()
        {
            Console.WriteLine("Dog is Sleepin with poshtak");
        }
    }
}