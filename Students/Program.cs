using System;
using System.Linq;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] studentData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Student student = new Student
                {
                    FirstName = studentData[0],
                    LastName = studentData[1],
                    Grade = double.Parse(studentData[2])
                };

                students.Add(student);
            }

            List<Student> sortedStudents = students
                .OrderByDescending(x => x.Grade)
                .ToList();

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
