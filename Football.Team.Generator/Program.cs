using System;
using System.Collections.Generic;

namespace Football.Team.Generator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var teams = new Dictionary<string, Team>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                var info = line.
                    Split(';', StringSplitOptions.RemoveEmptyEntries);

                var action = info[0];

                try
                {
                    if (action == "Team")
                    {
                        var name = info[1];
                        var team = new Team(name);
                        teams.Add(name, team);
                    }
                    else if (action == "Add")
                    {
                        var teamName = info[1];

                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            continue;
                        }

                        var playerName = info[2];
                        int endurance = int.Parse(info[3]);
                        int sprint = int.Parse(info[4]);
                        int dribble = int.Parse(info[5]);
                        int passing = int.Parse(info[6]);
                        int shooting = int.Parse(info[7]);

                        var player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                        teams[teamName].AddPlayer(player);
                    }
                    else if (action == "Remove")
                    {
                        var teamName = info[1];
                        var playerName = info[2];

                        teams[teamName].RemovePlayer(playerName);
                    }
                    else if (action == "Rating")
                    {
                        var teamName = info[1];

                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            continue;
                        }

                        Console.WriteLine($"{teamName} - {teams[teamName].Rating}");
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }               
            }
        }
    }
}
