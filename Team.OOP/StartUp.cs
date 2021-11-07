using System;
using System.Collections.Generic;

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
                var info = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var firstName = info[0];
                var lastName = info[1];
                var age = int.Parse(info[2]);
                var salary = decimal.Parse(info[3]);

                var person = new Person(firstName, lastName, age, salary);
                persons.Add(person);
            }

            var percentage = decimal.Parse(Console.ReadLine());

            foreach (var person in persons)
            {
                person.IncreaseSalary(percentage);
                Console.WriteLine(person.ToString());
            }

            Team team = new Team("SoftUni");

            foreach (Person person in persons)
            {
                team.AddPlayer(person);
            }
        }
    }
}
