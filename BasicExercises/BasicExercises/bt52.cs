using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt52
    {
        static void Main()
        {
            /*int[] arr1 = { 1, 2, 5 };
            int[] arr2 = { 0, 3, 8 };
            int[] arr3 = {-1, 0, 2};
            //int[] arr4;
            Console.WriteLine("arr4 = [{0},{1},{2}]", arr1[1], arr2[1], arr3[1]);*/

            int[] array1 = { 1, 2, 5 };        
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", array1));
            int[] array2 = { 0, 3, 8 };
            Console.WriteLine("\nArray2: [{0}]", string.Join(", ", array2));
            int[] array3 = { -1, 0, 2 };
            Console.WriteLine("\nArray3: [{0}]", string.Join(", ", array3));
            int[] new_array = { array1[1], array2[1], array3[1] };
            Console.WriteLine("\nNew array: [{0}]", string.Join(", ", new_array));
        }
    }
}
