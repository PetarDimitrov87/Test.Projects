using System;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleData = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Article article = new Article
            {
                Title = articleData[0],

                Content = articleData[1],

                Author = articleData[2]
            };

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandParts = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string command = commandParts[0];
                string argument = commandParts[1];

                if (command == "Edit")
                {
                    article.Edit(argument);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(argument);
                }
                else if (command == "Rename")
                {
                    article.Rename(argument);
                }
            }

            Console.WriteLine(article);
        }
    }
}
