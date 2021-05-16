using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int minNum = GetSmallestNumber(firstNum, secondNum, thirdNum);

            Console.WriteLine(minNum);
        }

        private static int GetSmallestNumber(int first, int second, int third)
        {
            int min = Math.Min
                (Math.Min(first, second), third);

            return min;
        }
    }
}
