using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> racers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToDictionary(x => x, x => 0);

            Regex nameRegex = new Regex(@"[A-Za-z]+");

            Regex digitsRegex = new Regex(@"\d");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of race")
                {
                    break;
                }

                MatchCollection letterMatches = nameRegex.Matches(input);
                MatchCollection digitsMatches = digitsRegex.Matches(input);

                string name = GetName(letterMatches);
                int sum = GetSum(digitsMatches);

                if (!racers.ContainsKey(name))
                {
                    continue;
                }

                racers[name] += sum;
            }

            string[] winners = racers
                .OrderByDescending(r => r.Value)
                .Take(3)
                .Select(r => r.Key)
                .ToArray();

            Console.WriteLine($"1st place: {winners[0]}");
            Console.WriteLine($"2nd place: {winners[1]}");
            Console.WriteLine($"3rd place: {winners[2]}");
        }

        private static int GetSum(MatchCollection matches)
        {
            int sum = 0;

            foreach (Match match in matches)
            {
                sum += int.Parse(match.Value);
            }

            return sum;
        }

        private static string GetName(MatchCollection matches)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                sb.Append(match.Value);
            }

            return sb.ToString();
        }
    }
}
