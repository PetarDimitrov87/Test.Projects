using System;
using System.Collections.Generic;
using System.Linq;

namespace Fund2021FinalExam3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Follower> followers = new Dictionary<string, Follower>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Log out")
                    break;

                string[] tokens = line.Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                string username = tokens[1];

                if (command == "New follower")
                {
                    if (!followers.ContainsKey(username))
                        followers.Add(username, new Follower());
                }
                else if (command == "Like")
                {
                    int likesCount = int.Parse(tokens[2]);

                    Follower follower;

                    if (!followers.TryGetValue(username, out follower))
                        followers.Add(username, follower = new Follower());

                    follower.Likes += likesCount;
                }
                else if (command == "Comment")
                {
                    Follower follower;

                    if (!followers.TryGetValue(username, out follower))
                        followers.Add(username, follower = new Follower());

                    follower.Comments++;
                }
                else if (tokens[0] == "Blocked")
                {
                    bool removed = followers.Remove(username);

                    if (!removed)
                        Console.WriteLine($"{username} doesn't exist.");
                }
            }

            Console.WriteLine($"{followers.Count} followers");

            foreach (var kv in followers.OrderByDescending(x => x.Value.Comments + x.Value.Likes))
            {
                Console.WriteLine($"{kv.Key}: {kv.Value.Comments + kv.Value.Likes}");
            }
        }
    }
}
