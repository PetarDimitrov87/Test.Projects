using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());

            char start = firstSymbol;
            char end = secondSymbol;

            if (secondSymbol < firstSymbol)
            {
                start = secondSymbol;
                end = firstSymbol;
            }

            PrintCharsInRange(start, end);
        }

        private static void PrintCharsInRange(char start, char end)
        {
            for (char i = (char)(start + 1); i < end; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
