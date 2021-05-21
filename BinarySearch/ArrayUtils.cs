using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class ArrayUtils
    {
        public static int BinarySearch(int[] array, int value)
        {
            int min = 0;
            int max = array.Length - 1;
            int mid = 0;

            while (min <= max)
            {
                mid = (min + max) / 2;

                if (value == array[mid])
                {
                    return mid;
                }
                else if (value < array[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return ~mid;
        }
    }
}
