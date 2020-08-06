using System;
using StaticSample;

namespace ExtensionMethodSample
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorVersionTwo calculator = new CalculatorVersionTwo();

            int x = 20;
            Console.WriteLine(x.IsGreaterThan(10));
            Console.WriteLine(x.IsLessThan(5));
        }
    }
}
