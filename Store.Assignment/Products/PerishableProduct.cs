namespace Store.Assignment
{
    public class PerishableProduct : Product
    {
        public PerishableProduct(string name, string brand, double price, DateTime expirationDate) 
            : base(name, brand, price)
        {
            this.ExpirationDate = expirationDate;
        }

        public DateTime ExpirationDate { get; private set; }

        public override double GetPriceAt(DateTime dateTime)
        {
            int days = DateUtils.GetDaysBetween(dateTime, ExpirationDate);

            if (days <= 0)
            {
                return 0.5 * Price;
            }

            if (days <= 5)
            {
                return 0.9 * Price;
            }

            return Price;
        }
    }
}
