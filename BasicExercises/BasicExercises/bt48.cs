using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt48
    {
        static void Main()
        {
            int[] num = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine(num.Length >= 1 && num[0].Equals(num[num.Length - 1]));
        }
    }
}
