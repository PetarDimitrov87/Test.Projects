namespace Store.Assignment
{
    public class Beverage : PerishableProduct
    {
        public Beverage(string name, string brand, double price, int quantity, DateTime expirationDate) 
            : base(name, brand, price, quantity, expirationDate)
        {
        }
    }
}
