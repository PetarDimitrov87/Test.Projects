using System;
using System.Collections.Generic;

namespace Valid.Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            bool result = IsValidExpression(expression);

            Console.WriteLine(result);
        }

        private static bool IsValidExpression(string expression)
        {           
            if (expression.Length % 2 != 0)
            {
                return false;
            }

            List<char> test = new List<char>();

            foreach (var symbol in expression)
            {
                if (Char.IsUpper(symbol))
                {
                    test.Add(symbol);
                }
                else
                {
                    if (test.Count == 0 ||
                        symbol != Char.ToLower(test[^1]))
                    {
                        return false;
                    }

                    test.RemoveAt(test.Count - 1);                  
                }
            }

            return test.Count == 0;
        }
    }
}
