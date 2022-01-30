﻿namespace Store.Assignment
{
    public class Food : PerishableProduct
    {
        public Food(string name, string brand, double price, int quantity, DateTime expirationDate) 
            : base(name, brand, price, quantity, expirationDate)
        {
        }
    }
}
