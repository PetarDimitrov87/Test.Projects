using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int length = random.Next(0, 11);

            int[] array = new int[length];

            array = GenerateRandomArray(length, 0, 101);

            PrintArray(array);

            Console.WriteLine();

            Array.Sort(array);

            PrintArray(array);

            Console.WriteLine();

            int value = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int index = Array.BinarySearch(array, value);

            PrintResult(index, value);
        }

        private static int[] GenerateRandomArray(int length, int minValue, int maxValue)
        {
            Random random = new Random();

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }

            return array;
        }

        private static void PrintArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }

        private static void PrintResult(int index, int key)
        {
            if (index < 0)
            {
                Console.WriteLine($"Element {key} not found in collection. The next greater element is at index {~index}.");
            }
            else
            {
                Console.WriteLine($"Element {key} found in collection at index {index}.");
            }
        }

    }
}
