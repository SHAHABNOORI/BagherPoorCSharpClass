using System;

namespace StaticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Mul(2, 6));

            Console.WriteLine(CalculatorVersionTwo.Plus(2, 10));

            CalculatorVersionTwo calculatorVersionTwo = new CalculatorVersionTwo();
            calculatorVersionTwo.Mul(2, 3);

        }
    }
}
