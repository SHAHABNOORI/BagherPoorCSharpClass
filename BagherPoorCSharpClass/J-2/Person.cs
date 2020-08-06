using System;

namespace J_2
{
    public class Person
    {


        public string FirstName;

        public string LastName;

        //private int _age;

        //public void AgeSetter(int age)
        //{
        //    if (_age > 0)
        //        _age = age;

        //    Console.WriteLine("Age most be upper than zero...");
        //}

        //public int AgeGetter() => _age;

        public int Age
        {
            get => Age;
            set
            {
                if (value < 0)
                    Console.WriteLine("Age most be upper than zero...");
            }
        }

        public string FullName { get; set; }

        public Address Address { get; set; }
    }
}