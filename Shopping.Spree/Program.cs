using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping.Spree
{
    class Program
    {
        static void Main(string[] args)
        {          
            try
            {
                var people = new Dictionary<string, Person>();
                var products = new Dictionary<string, Product>();

                var peopleInfo = Console.ReadLine()
                    .Split(';', StringSplitOptions.RemoveEmptyEntries);

                var productsInfo = Console.ReadLine()
                    .Split(';', StringSplitOptions.RemoveEmptyEntries);

                foreach (var current in peopleInfo)
                {
                    var values = current.
                        Split('=', StringSplitOptions.RemoveEmptyEntries);

                    var name = values[0];
                    var money = decimal.Parse(values[1]);

                    var person = new Person(name, money);
                    people.Add(person.Name, person);
                }

                foreach (var current in productsInfo)
                {
                    var values = current.
                        Split('=', StringSplitOptions.RemoveEmptyEntries);

                    var name = values[0];
                    var cost = decimal.Parse(values[1]);

                    var product = new Product(name, cost);
                    products.Add(product.Name, product);
                }

                while (true)
                {
                    var line = Console.ReadLine();

                    if (line == "END")
                    {
                        break;
                    }

                    var purchaseInfo = line
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    var personName = purchaseInfo[0];
                    var productName = purchaseInfo[1];

                    var person = people[personName];
                    var product = products[productName];

                    if (person.Money - product.Cost < 0)
                    {
                        Console.WriteLine($"{person.Name} can't afford {product.Name}");
                        continue;
                    }

                    person.AddProduct(product);
                    Console.WriteLine($"{personName} bought {productName}");
                }

                foreach (var person in people)
                {
                    var productMessage = person.Value.Products.Count == 0
                        ? "Nothing bought"
                        : string.Join(", ", person.Value.Products.Select(x => x.Name));

                    Console.WriteLine($"{person.Key} - {productMessage}");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }           
        }
    }
}
