using System;
using System.Collections.Generic;

namespace GenericSortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> students = new SortedDictionary<int, string>();

            students.Add(20, "Shahab");
            students.Add(10, "Mahdi");
            students.Add(5, "Vahid");
            students.Add(3, "Reza");
            students.Add(6, "Saman");
            students.Add(1, "Sadegh");

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} {student.Value}");
            }
        }
    }
}
