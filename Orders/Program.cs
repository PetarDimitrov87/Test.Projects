using System;
using System.Linq;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> priceByProduct = new Dictionary<string, decimal>();
            Dictionary<string, int> quantityByProduct = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "buy")
                {
                    break;
                }

                string[] parts = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string product = parts[0];
                decimal price = decimal.Parse(parts[1]);
                int quantity = int.Parse(parts[2]);

                if (priceByProduct.ContainsKey(product))
                {
                    quantityByProduct[product] += quantity;
                    priceByProduct[product] = price;
                }
                else
                {
                    priceByProduct.Add(product, price);
                    quantityByProduct.Add(product, quantity);
                }
            }

            Dictionary<string, decimal> sorted = priceByProduct
                .OrderByDescending(kvp => kvp.Value * quantityByProduct[kvp.Key])
                .ToDictionary(x => x.Key, x => x.Value * quantityByProduct[x.Key]);

            foreach (var kvp in sorted)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }
        }
    }
}
