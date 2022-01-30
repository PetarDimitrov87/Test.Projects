namespace Store.Assignment
{
    public abstract class Product
    {
        public Product(string name, string brand, double price, int quantity)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Name { get; private set; }

        public string Brand { get; private set; }

        public double Price { get; private set; }

        public int Quantity { get; private set; }

        public virtual double GetPriceAt(DateTime dateTime)
        {
            return Price;
        }
    }
}
