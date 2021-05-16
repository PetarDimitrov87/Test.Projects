using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }           

            int errorCount = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (errorCount >= 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    errorCount++;
                }             
            }  
        }
    }
}
