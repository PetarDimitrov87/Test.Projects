using System;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int rotations = int.Parse(Console.ReadLine());

            rotations = rotations % arr.Length;

            for (int rotation = 0; rotation < rotations; rotation++)
            {
                string firstElement = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    arr[i - 1] = arr[i];
                }

                arr[arr.Length - 1] = firstElement;
            }

            foreach (string element in arr)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }
    }
}
