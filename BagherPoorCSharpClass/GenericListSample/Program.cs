using System;
using System.Collections.Generic;

namespace GenericListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Student> students = new List<Student>();
            //students.Add(new Student() { FullName = "Ali Mahdavi" });

            var students = new List<Student>
            {
                new Student() {FullName = "Ali Mahdavi"},
                new Student() {FullName = "Mahdi Naderi"},
                new Student() {FullName = "Sadegh Miri"}
            };

            students.Remove(students[0]);

            //foreach (var student in students)
            //{
            //   Console.WriteLine(student.FullName);
            //}

            var st=new List<Student>();

            st.AddRange(students);
            foreach (var student in st)
            {
                Console.WriteLine(student.FullName);
            }

        }
    }
}
