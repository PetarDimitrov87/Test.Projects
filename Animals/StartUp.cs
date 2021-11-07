using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var animals = new List<Animal>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "Beast!")
                {
                    break;
                }

                var info = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var name = info[0];
                var age = int.Parse(info[1]);
                var gender = info[2];

                if (line == "Cat")
                {
                    var cat = new Cat(name, age, gender);
                    animals.Add(cat);
                }
                else if (line == "Dog")
                {
                    var dog = new Dog(name, age, gender);
                    animals.Add(dog);
                }
                else if (line == "Frog")
                {
                    var frog = new Frog(name, age, gender);
                    animals.Add(frog);
                }
                else if (line == "Tomcat")
                {
                    var tomcat = new Tomcat(name, age);
                    animals.Add(tomcat);
                }
                else if (line == "Kitten")
                {
                    var kitten = new Kitten(name, age);
                    animals.Add(kitten);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine(animal.ProduceSound());
            }
        }
    }
}
