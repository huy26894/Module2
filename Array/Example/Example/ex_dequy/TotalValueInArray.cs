using System;
using System.Collections.Generic;
using System.Text;

namespace Example.ex_dequy
{
    public class TotalValueInArray
    {
        public static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(string.Join(",", array));
            Console.WriteLine("Sum of Array is {0}:",Total(array, array.Length));
        }

        public static long Total(int[] a, int n)   // n là length
        {
            if (n == 0)
                return 0;         
            return Total(a, n - 1) + a[n - 1];
        }
    }
}
