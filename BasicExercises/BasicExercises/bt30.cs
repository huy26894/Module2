using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt30
    {
        static void Main()
        {
            int[] arr1 = { 1, 3, -5, 4 };
            int[] arr2 = { 1, 4, -5, -2 };
            Console.WriteLine("Array1: [{0}]", string.Join(", ", arr1));
            Console.WriteLine("Array2: [{0}]", string.Join(", ", arr2));
            Console.WriteLine("Multiply corresponding elements of two arrays: ");
            for (int i=0;i<arr1.Length;i++)
            {          
                Console.Write(arr1[i] * arr2[i] + " ");
            }
            Console.ReadKey();
            
        }
    }
}
