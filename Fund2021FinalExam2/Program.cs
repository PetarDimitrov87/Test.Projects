using System;
using System.Text.RegularExpressions;

namespace Fund2021FinalExam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex regex = new Regex(@"^(?<symbols>[^]]+)>(?<numbers>[\d]+)\|(?<lowerLetters>[a-z]+)\|(?<upperLetters>[A-Z]+)\|(?<chars>[^<>]+)<\1$");

            for (int i = 0; i < n; i++)
            {
                string password = Console.ReadLine();

                Match match = regex.Match(password);

                if (!match.Success)
                {
                    Console.WriteLine("Try another password!");
                    continue;
                }
             
                string numbers = match.Groups["numbers"].Value;
                string lowerCase = match.Groups["lowerLetters"].Value;
                string upperCase = match.Groups["upperLetters"].Value;
                string chars = match.Groups["chars"].Value;

                string encrypted = string.Concat(numbers, lowerCase, upperCase, chars);

                Console.WriteLine($"Password: {encrypted}");

            }
        }
    }
}
