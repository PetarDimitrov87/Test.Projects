namespace Store.Assignment
{
    public static class Cashier
    {
        public static void GetReceipt(List<Product> cart, DateTime dateAndTimeOfPurchase)
        {                                  
            Console.WriteLine($"Date: {dateAndTimeOfPurchase}");
            Console.WriteLine("---Products---");
            Console.WriteLine();
            Console.WriteLine();

            double subtotal = 0;
            double total = 0;

            foreach (var product in cart)
            {
                subtotal += product.Quantity * product.Price;

                var price = product.GetPriceAt(dateAndTimeOfPurchase);
                total += product.Quantity * price;

                Console.WriteLine($"{product.Name} - {product.Brand}");
                Console.WriteLine($"{product.Quantity} * {price:F2} = {product.Quantity * price:F2}");
            }

            double totalDiscount = subtotal - total;

            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine($"SUBTOTAL: {subtotal:F2}");
            Console.WriteLine($"DISCOUNT: - {totalDiscount:F2}");
            Console.WriteLine();
            Console.WriteLine($"TOTAL: {total:F2}");
        }       
    }
}
