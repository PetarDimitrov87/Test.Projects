namespace Store.Assignment
{
    public abstract class Product
    {
        public Product(string name, string brand, double price, double quantity)
        {
            if (price <= 0)
            {
                throw new ArgumentException("Price cannot be 0 or negative.");
            }

            if (quantity <= 0)
            {
                throw new ArgumentException("Quantity cannot be 0 or negative.");
            }

            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Name { get; private set; }

        public string Brand { get; private set; }

        public double Price { get; private set; }

        public double Quantity { get; private set; }

        public virtual double GetPriceOn(DateTime dateTime)
        {
            return Price;
        }
    }
}
