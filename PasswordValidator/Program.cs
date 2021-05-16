using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool passwordIsValid = true;

            if (!HasValidLength(password))
            {
                Console.WriteLine
                ("Password must be between 6 and 10 characters");
                passwordIsValid = false;
            }

            if (ContainsInvalidChars(password))
            {
                Console.WriteLine
                ("Password must consist only of letters and digits");
                passwordIsValid = false;
            }

            if (!ContainsDigitsCount(password, 2))
            {
                Console.WriteLine("Password must have at least 2 digits");
                passwordIsValid = false;
            }

            if (passwordIsValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool HasValidLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }

        private static bool ContainsInvalidChars(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool ContainsDigitsCount(string password, int count)
        {
            int digitsFoundCount = 0;

            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    digitsFoundCount++;

                    if (digitsFoundCount == count)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
