using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var data = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var firstName = data[0];
                var lastName = data[1];
                var age = int.Parse(data[2]);

                var person = new Person(firstName, lastName, age);
                persons.Add(person);
            }

            var ordered = persons
                .OrderBy(p => p.FirstName)
                .ThenBy(p => p.Age)
                .ToList();

            foreach (var person in ordered)
            {
                Console.WriteLine(person);
            }
        }
    }
}
