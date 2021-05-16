using System;
using System.Text;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string stripped = RemoveSpecialChars(text);

            bool isPalindrome = IsPalindrome(stripped);

            Console.WriteLine(isPalindrome);
        }

        private static bool IsPalindrome(string text)
        {
            int length = text.Length;

            if (length == 0)
            {
                return false;
            }

            for (int i = 0; i < length / 2; i++)
            {
                if (text[i] != text[length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsSpecialChar(char symbol)
        {
            return char.IsNumber(symbol) ||
                   char.IsPunctuation(symbol) ||
                   symbol == ' ';
        }

        private static string RemoveSpecialChars(string text)
        {
            int length = text.Length;

            StringBuilder sb = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                if (!IsSpecialChar(text[i]))
                {
                    sb.Append(text[i]);
                }
            }

            return sb.ToString();
        }
    }
}
