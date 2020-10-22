using System;
using System.Collections.Generic;

namespace GenericDictionarySample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Teacher> teachers = new Dictionary<int, Teacher>();
            teachers.Add(10, new Teacher() { FullName = "Shahab Noori Goodarzi" });
            teachers.Add(20, new Teacher() { FullName = "Hamid Molai" });
            //teachers.Add(20, new Teacher() { FullName = "Hirad Hooman" }); Error Duplicate Key
            teachers.Add(40, new Teacher() { FullName = "Mahdi Miri" });

            //foreach (var teacher in teachers)
            //{
            //    Console.WriteLine($"{teacher.Key} {teacher.Value.FullName}");
            //}


            Console.WriteLine(teachers[20].FullName);
        }
    }
}
