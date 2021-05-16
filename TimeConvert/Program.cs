using System;

namespace TimeConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());

            string time = TimeConvert(minutes);

            Console.WriteLine(time);
        }

        private static string TimeConvert(int minutes)
        {
            if (minutes < 0)
            {
                return "Error. Time cannot be negative.";
            }
            
            int hours = minutes / 60;
            minutes = minutes % 60;

            return $"{hours}:{minutes}";
        }
    }
}
