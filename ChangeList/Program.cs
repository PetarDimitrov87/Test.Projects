using System;
using System.Linq;
using System.Collections.Generic;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] parts = input.Split();
                string command = parts[0];

                if (command == "Delete")
                {
                    int element = int.Parse(parts[1]);

                    numbers.RemoveAll(n => n == element);
                }
                else if (command == "Insert")
                {
                    int element = int.Parse(parts[1]);
                    int index = int.Parse(parts[2]);

                    numbers.Insert(index, element);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
