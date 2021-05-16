using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double balance = 0;
            
            while (input != "Start")
            {              
                double coins = double.Parse(input);

                if (coins == 0.1 ||
                    coins == 0.2 ||
                    coins == 0.5 ||
                    coins == 1 ||
                    coins == 2)
                {                  
                    balance += coins;                  
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                double productPrice = 0;
                
                if (input == "Nuts")
                {
                    productPrice = 2;                   
                }
                else if (input == "Water")
                {
                    productPrice = 0.7;
                }
                else if (input == "Crisps")
                {
                    productPrice = 1.5;
                }
                else if (input == "Soda")
                {
                    productPrice = 0.8;
                }
                else if (input == "Coke")
                {
                    productPrice = 1;
                }

                if (productPrice != 0)
                {
                    if (balance >= productPrice)
                    {
                        Console.WriteLine($"Purchased {input.ToLower()}");
                        balance -= productPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {balance:F2}");

        }
    }
}
