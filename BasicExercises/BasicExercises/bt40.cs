using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt40
    {
        static void Main()
        {
            Console.WriteLine("\nInput first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            int n = 20;
            var value1 = Math.Abs(x - n);
            var value2 = Math.Abs(y - n);
            Console.WriteLine(value1 == value2 ? 0 : (value1 < value2) ? x : y);
        }
    }
}
