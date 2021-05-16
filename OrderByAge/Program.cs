using System;
using System.Linq;
using System.Collections.Generic;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "End")
                {
                    break;
                }

                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                Person person = new Person
                {
                    Name = name,
                    Id = id,
                    Age = age
                };

                persons.Add(person);
            }

            List<Person> sortedPersons = persons
                .OrderBy(a => a.Age)
                .ToList();

            foreach (var person in sortedPersons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
