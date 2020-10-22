using System;
using System.Collections.Generic;

namespace GenericSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> students = new SortedList<int, string>();
            students.Add(4, "Shahab");
            students.Add(2, "Mahdi");
            students.Add(3, "Vahid");
            students.Add(1, "Behnam");
            students.Add(1, "Morad");

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} {student.Value}");
            }
        }
    }
}
