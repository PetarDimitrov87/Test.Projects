using System;
using System.Collections.Generic;

namespace First.NonRepeating.Character
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine();

            char result = GetFirstNonRepeatingCharacter(text);

            Console.WriteLine(result);
        }

        private static char GetFirstNonRepeatingCharacter(string text)
        {
            int length = text.Length;

            Dictionary<char, int> occurencesByChar = new Dictionary<char, int>();

            for (int i = 0; i < length; i++)
            {
                char c = text[i];

                if (occurencesByChar.ContainsKey(c))
                {
                    occurencesByChar[c]++;
                }
                else
                {
                    occurencesByChar.Add(c, 1);
                }
            }

            foreach (var kvp in occurencesByChar)
            {
                if (kvp.Value == 1)
                {
                    return kvp.Key;
                }
            }

            return '_';
        }
    }
}
