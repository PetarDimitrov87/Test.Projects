using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int firstNumber = numbers[0];
                int secondNumber = numbers[1];

                if (i % 2 == 0)
                {
                    firstArr[i] = firstNumber;
                    secondArr[i] =secondNumber;
                }
                else
                {
                    firstArr[i] = secondNumber;
                    secondArr[i] = firstNumber;
                }
            }

            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
