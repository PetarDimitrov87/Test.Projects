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

        public string Name { get; private set; }

        public string Brand { get; private set; }

        public double Price { get; private set; }
    }
}
