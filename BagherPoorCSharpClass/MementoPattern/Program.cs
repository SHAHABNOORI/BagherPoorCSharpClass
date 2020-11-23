using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.AddFule(2000);
            car.IncreaseSpeed();
            car.Killometer();
            car.IncreaseSpeed();
            car.Killometer();
            car.IncreaseSpeed();
            car.Killometer();
            car.IncreaseSpeed();
            car.Killometer();
            car.DecreaseSpeed();
            car.Killometer();

            CarState carState = car.GetState();


            Car c1 = new Car(carState);

            Console.WriteLine($"{c1.GetState().Fule} {c1.GetState().Speed}");
        }
    }
}
