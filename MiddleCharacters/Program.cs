using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string middleElement = GetMiddleChar(text);

            Console.WriteLine(middleElement);
        }

        private static string GetMiddleChar(string text)
        {
            if (text.Length % 2 == 00)
            {
                return $"{text[text.Length / 2 - 1]}{text[text.Length / 2]}";
            }

            return $"{text[(text.Length - 1) / 2]}";
        }
    }
}
