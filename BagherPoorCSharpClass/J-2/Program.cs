using System;

namespace J_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Daneshjoo daneshjoo = new Daneshjoo();

            Person pOne = new Person
            {
                FullName = "Shahab Noori Goodarzi",
                Age = -2,
                Address = new Address
                {
                    City = "Karaj",
                    Street = "Qalam",
                    Pelak = "14"
                }
            };
            //pOne.AgeSetter(0);
            Register(ref pOne);

            Console.WriteLine($"{pOne.FullName} with addrress {pOne.Address.City} {pOne.Address.Street} {pOne.Address.Pelak}");
        }

        static void Register(ref Person person)
        {
            person = new Person
            {
                FullName = "Amin Bagherpoor"
                    ,
                Address = new Address
                {
                    City = "Tehran",
                    Street = "Falake Aval",
                    Pelak = "152"
                }
            };

            Console.WriteLine($"{person.FullName} with addrress {person.Address.City} {person.Address.Street} {person.Address.Pelak}");
        }
    }
}
