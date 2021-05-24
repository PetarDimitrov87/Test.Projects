using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());

            int totalPeople = 0;

            int[] peopleInTrain = new int[wagonsCount];

            for (int i = 0; i < peopleInTrain.Length; i++)
            {
                peopleInTrain[i] = int.Parse(Console.ReadLine());
                totalPeople += peopleInTrain[i];              
            }

            foreach (int wagon in peopleInTrain)
            {
                Console.Write($"{wagon} ");
            }

            Console.WriteLine();

            Console.WriteLine($"{totalPeople}");
        }
    }
}
