using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class RandomUtils
    {
        private static Random random = new Random();

        public static int GenerateRandomValue(int minValue, int maxValue)
        {
            int length = random.Next(minValue, maxValue + 1);

            return length;
        }

        public static int[] GenerateRandomArray(int length, int minValue, int maxValue)
        {
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = GenerateRandomValue(minValue, maxValue);
            }

            return array;
        }
    }
}
