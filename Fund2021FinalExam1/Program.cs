using System;
using System.Text;

namespace Fund2021FinalExam1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Finish")
                {
                    break;
                }

                string[] tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Replace")
                {
                    char currentChar = char.Parse(tokens[1]);
                    char newChar = char.Parse(tokens[2]);

                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[i] == currentChar)
                        {
                            text = text.Replace(currentChar, newChar);
                        }
                    }

                    Console.WriteLine(text);
                }
                else if (tokens[0] == "Cut")
                {
                    int start = int.Parse(tokens[1]);
                    int end = int.Parse(tokens[2]);

                    if ((start < 0 || start >= text.Length) ||
                        (end < 0 || end >= text.Length))
                    {
                        Console.WriteLine("Invalid indices!");
                        continue;
                    }

                    text = text.Remove(start, end - start + 1);

                    Console.WriteLine(text);
                }
                else if (tokens[0] == "Make")
                {                 
                    string modify = tokens[1];

                    if (modify == "Upper")
                    {
                        foreach (var letter in text)
                        {
                            text = text.ToUpper();
                        }

                        Console.WriteLine(text);
                    }
                    else if (modify == "Lower")
                    {
                        foreach (var letter in text)
                        {
                            text = text.ToLower();
                        }

                        Console.WriteLine(text);
                    }                 
                }
                else if (tokens[0] == "Check")
                {
                    string check = tokens[1];

                    if (text.Contains(check))
                    {
                        Console.WriteLine($"Message contains {check}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {check}");
                    }
                }
                else if (tokens[0] == "Sum")
                {
                    int start = int.Parse(tokens[1]);
                    int end = int.Parse(tokens[2]);

                    if ((start < 0 || start >= text.Length) ||
                        (end < 0 || end >= text.Length))
                    {
                        Console.WriteLine("Invalid indices!");
                        continue;
                    }

                    string substring = text.Substring(start, end - start + 1);

                    int sum = 0;

                    foreach (var symbol in substring)
                    {
                        sum += symbol;
                    }

                    Console.WriteLine(sum);
                }
            }
        }
    }
}
