using System;

namespace J_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //int y = x;
            //y++;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Number numberOne = new Number() { Num = 10 };
            //Number numberTwo = numberOne;
            //SampleMethod(numberOne, numberTwo);
            //By Value
            //Sum(20, 10);

            int numOne = 20;
            int numTwo = 30;

            //Minus(ref numOne, ref numTwo);
            Mull(out numOne, out numTwo);

            Console.WriteLine($"Number One : {numOne}");
            Console.WriteLine($"Number Two : {numTwo}");
            Console.ReadKey();
        }

        private static void SampleMethod(Number numberOne, Number numberTwo)
        {
            numberTwo.Num = 20;
            Console.WriteLine(numberOne.Num);
            Console.WriteLine(numberTwo.Num);
        }

        //Expression Body
        private static void Sum(ref int x, ref int y) => Console.WriteLine(x + y);

        private static void Minus(ref int x, ref int y)
        {

            Console.WriteLine(x - y);
            x = 300;
            y = 200;
        }

        private static void Mull(out int x, out int y)
        {
            x = 300;
            y = 200;
            Console.WriteLine(x * y);
        }
    }
}
