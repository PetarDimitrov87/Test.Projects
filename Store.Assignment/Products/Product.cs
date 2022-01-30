namespace Store.Assignment
{
    public abstract class Product
    {
        public Product(string name, string brand, double price)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
        }

        public string Name { get; set; }

        public string Brand { get; set; }

        public double Price { get; set; }
    }
}
