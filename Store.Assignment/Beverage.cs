namespace Store.Assignment
{
    public class Beverage : PerishableProduct
    {
        public Beverage(string name, string brand, double price, DateTime expirationDate) : base(name, brand, price, expirationDate)
        {
        }
    }
}
