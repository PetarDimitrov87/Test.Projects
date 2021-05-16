using System;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var username in usernames)
            {
                if (IsValid(username))
                {
                    Console.WriteLine(username);
                }
            }
        }

        private static bool IsValid(string username)
        {
            return HasValidLength(username) && ContainsValidSymbols(username);
        }

        private static bool ContainsValidSymbols(string username)
        {
            foreach (var symbol in username)
            {
                if (!char.IsLetterOrDigit(symbol) &&
                    symbol != '-' &&
                    symbol != '_')
                {
                    return false;
                }
            }

            return true;
        }

        private static bool HasValidLength(string username)
        {
            return username.Length >= 3 && username.Length <= 16;
        }
    }
}
