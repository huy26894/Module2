using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt47
    {
        static void Main()
        {
            int count = 0;
            int[] number = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            for (int i = 0; i < number.Length; i++)
            {
                count += number[i];
            }
            Console.WriteLine(count);
        }
        
    }
}
