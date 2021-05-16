using System;
using System.Linq;
using System.Collections.Generic;

namespace Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] articleData = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                Article article = new Article
                {
                    Title = articleData[0],
                    Content = articleData[1],
                    Author = articleData[2]
                };

                articles.Add(article);
            }

            string sortingCriteria = Console.ReadLine();

            List<Article> sorted = new List<Article>();

            if (sortingCriteria == "title")
            {
                sorted = articles
                    .OrderBy(x => x.Title)
                    .ToList();
            }
            else if (sortingCriteria == "content")
            {
                sorted = articles
                    .OrderBy(x => x.Content)
                    .ToList();
            }
            else if (sortingCriteria == "author")
            {
                sorted = articles
                    .OrderBy(x => x.Author).ToList();
            }

            foreach (var article in sorted)
            {
                Console.WriteLine(article);
            }
        }
    }
}

