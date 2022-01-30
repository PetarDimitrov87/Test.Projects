namespace Store.Assignment
{
    public class PerishableProduct : Product
    {
        public PerishableProduct(string name, string brand, double price, DateTime expirationDate) : base(name, brand, price)
        {
            this.ExpirationDate = expirationDate;
        }

        public DateTime ExpirationDate { get; set; }

    }
}
