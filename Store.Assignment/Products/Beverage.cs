namespace Store.Assignment
{
    public class Beverage : PerishableProduct
    {
        public Beverage(string name, string brand, double price, double quantity, DateTime expirationDate) 
            : base(name, brand, price, quantity, expirationDate)
        {
        }
    }
}
