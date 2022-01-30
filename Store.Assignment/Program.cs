// See https://aka.ms/new-console-template for more information
using Store.Assignment;

class Program
{
    static void Main(string[] args)
    {
        var products = new List<Product>();

        var food = new Food("apples", "BrandA", 1.50, 2.45, new DateTime(2021, 6, 14));
        products.Add(food);

        var beverage = new Beverage("milk", "BrandM", 0.99, 3, new DateTime(2022, 2, 2));
        products.Add(beverage);

        var clothing = new Clothing("T-shirt", "BrandT", 15.99, 2, Size.M, System.Drawing.Color.Violet);
        products.Add(clothing);

        var appliances = new Appliance("laptop", "BrandL", 2345, 1, "ModelL", new DateTime(2021, 3, 3), 1.125);
        products.Add(appliances);

        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name} - {product.Brand} - {product.Price}");
        }

        Cashier.GetReceipt(products, new DateTime(2021, 6, 14, 12, 34, 56));
    }
}
