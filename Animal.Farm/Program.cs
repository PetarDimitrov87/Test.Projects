using System;
using AnimalFarm.Models;

namespace AnimalFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var name = Console.ReadLine();
                var age = int.Parse(Console.ReadLine());

                var chicken = new Chicken(name, age);

                Console.WriteLine(
                    $"Chicken {chicken.Name} (age {chicken.Age}) can produce {chicken.ProductPerDay} eggs per day.");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
