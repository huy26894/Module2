using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt57
    {
        static int adjacent_Elements_Product(int[] array)
        {
            int max = 0;
            for (int i = 1; i < array.Length -1; i ++)
            {
                max = (array[i] * array[i + 1]) > max ? max = (array[i] * array[i + 1]) : max;
            }
            return max;
        }
        static void Main()
        {
            Console.WriteLine(adjacent_Elements_Product(new int[] { 2, 4, 2, 6, 9, 3 }));
        }
    }
}
