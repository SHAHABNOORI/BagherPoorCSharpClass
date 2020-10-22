using System;
using System.Collections.Generic;

namespace HashsetSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashSet<string> students = new HashSet<string>();

            //students.Add("Shahab");
            //students.Add("Mahdi");
            //students.Add("Vahid");
            //students.Add("Shahab");


            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}

            HashSet<Point> points = new HashSet<Point>();

            points.Add(new Point(10, 20));
            points.Add(new Point(10, 20));
            points.Add(new Point(10, 20));
            points.Add(new Point(10, 20));
            points.Add(new Point(10, 20));

            foreach (var point in points)
            {
                Console.WriteLine($"{point.X} {point.Y}");
            }
        }
    }
}
