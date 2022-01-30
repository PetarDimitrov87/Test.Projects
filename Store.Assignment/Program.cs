// See https://aka.ms/new-console-template for more information
using Store.Assignment;

class Program
{
    static void Main(string[] args)
    {
        var date1 = new DateTime(1987, 8, 26, 10, 15, 28);

        var date2 = new DateTime(1987, 5, 26, 11, 23, 15);

        var timeSpan = date1 - date2;

        var result = timeSpan.Days;
        Console.WriteLine(result);

        var products = new Dictionary<Product, double>();

        var food = new Food("apples", "BrandA", 1.50, new DateTime(2021, 6, 14));
        products.Add(food, 2.45);

        var beverage = new Beverage("milk", "BrandM", 0.99, new DateTime(2022, 2, 2));
        products.Add(beverage, 3);

        var clothing = new Clothing("T-shirt", "BrandT", 15.99, Size.M, "violet");
        products.Add(clothing, 2);

        var appliances = new Appliance("laptop", "BrandL", 2345, "ModelL", new DateTime(2021, 3, 3), 1.125);
        products.Add(appliances, 1);

        foreach (var product in products)
        {
            Console.WriteLine($"{product.Key.Name} - {product.Key.Brand} - {product.Key.Price}");
        }

        Cashier.GetReceipt(products, new DateTime(2021, 6, 14, 12, 34, 56));
    }
}
