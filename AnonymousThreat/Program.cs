﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(" ")
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "3:1")
                {
                    break;
                }

                string[] parts = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(parts[1]);
                    int endIndex = int.Parse(parts[2]);

                    if (startIndex >= elements.Count || endIndex < 0)
                    {
                        continue;
                    }

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (endIndex >= elements.Count)
                    {
                        endIndex = elements.Count - 1;
                    }

                    string merged = string.Empty;

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        string element = elements[i];
                        merged += element;
                    }

                    elements.RemoveRange(startIndex, endIndex - startIndex + 1);
                    elements.Insert(startIndex, merged);
                }
                else if (command == "divide")
                {
                    int index = int.Parse(parts[1]);
                    int partitions = int.Parse(parts[2]);

                    string element = elements[index];

                    elements.RemoveAt(index);

                    int partitionSize = element.Length / partitions;

                    List<string> substrings = new List<string>();
                    
                    for (int i = 0; i < partitions - 1; i++)
                    {
                        string substring = element.Substring(i * partitionSize, partitionSize);
                        substrings.Add(substring);
                    }

                    string lastSubstring = element.Substring((partitions - 1) * partitionSize);
                    substrings.Add(lastSubstring);
                    
                    elements.InsertRange(index, substrings);
                }
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
