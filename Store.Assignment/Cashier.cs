namespace Store.Assignment
{
    public static class Cashier
    {
        public static void GetReceipt(List<Product> cart, DateTime dateAndTimeOfPurchase)
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

                Console.WriteLine($"{product.Name} - {product.Brand}");
                Console.WriteLine($"{product.Quantity} * {product.Price:F2} = {product.Quantity * product.Price:F2}");
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
