using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt53
    {
        static void Main()
        {
            int[] arr = { 2, 4, 7, 8, 6 };
            Console.WriteLine("Array : [{0}]", string.Join(", ", arr));
            Console.WriteLine("Check if an array contains an odd number? " + even(arr));          
        }
        static bool even(int[] arr)
        {
            foreach(var n in arr)
            {
                if (n%2 != 0)
                {
                    return true;
                }              
            }
            return false;                                   
        }
    }
}
