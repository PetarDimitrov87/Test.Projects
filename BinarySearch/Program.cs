using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = RandomUtils.GenerateRandomValue(0, 10);     

            int[] array = RandomUtils.GenerateRandomArray(length, 0, 100);

            PrintArray(array);

            Console.WriteLine();

            Array.Sort(array);

            PrintArray(array);

            Console.WriteLine();

            int value = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int result = ArrayUtils.BinarySearch(array, value);

            PrintResult(result, value);
        }

        private static void PrintArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }

        private static void PrintResult(int index, int value)
        {
            if (index < 0)
            {
                Console.WriteLine($"Element {value} not found in collection. The next greater element is at index {~index}.");
            }
            else
            {
                Console.WriteLine($"Element {value} found in collection at index {index}.");
            }
        }
    }
}
