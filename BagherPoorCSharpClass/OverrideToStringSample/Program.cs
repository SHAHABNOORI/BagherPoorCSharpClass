using System;

namespace OverrideToStringSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = "Shahab",
                LastName = "Noori"
            };

            Console.WriteLine(person);
        }
    }
}
