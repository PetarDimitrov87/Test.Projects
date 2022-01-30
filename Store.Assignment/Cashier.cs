namespace Store.Assignment
{
    public static class Cashier
    {
        public static void GetReceipt(Dictionary<Product, double> cart, DateTime dateAndTimeOfPurchase)
        {
            double subtotal = 0;
            double totalDiscount = 0;
            double total = subtotal - totalDiscount;

            Console.WriteLine($"Date: {dateAndTimeOfPurchase}");
            Console.WriteLine("---Products---");
            Console.WriteLine();
            Console.WriteLine();

            foreach (var product in cart)
            {
                var discount = 0;
                var type = product.GetType();
                if (type.Equals(typeof(PerishableProduct)))
                {
                    
                }

                Console.WriteLine($"{product.Key.Name} - {product.Key.Brand}");
                Console.WriteLine($"{product.Value} * {product.Key.Price:F2} = {product.Value * product.Key.Price:F2}");
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine($"SUBTOTAL: {subtotal:F2}");
            Console.WriteLine($"DISCOUNT: -{totalDiscount:F2}");
            Console.WriteLine();
            Console.WriteLine($"TOTAL: {total:F2}");
        }       
    }
}
