namespace Store.Assignment
{
    public class Food : PerishableProduct
    {
        public Food(string name, string brand, double price, DateTime expirationDate) 
            : base(name, brand, price, expirationDate)
        {
        }
    }
}
