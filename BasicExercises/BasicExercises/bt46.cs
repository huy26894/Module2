using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt46
    {
        static void Main()
        {
            Console.WriteLine("Input the Integer : ");
            int x = int.Parse(Console.ReadLine());
            int[] number = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };         
            Console.WriteLine(number[0] == x || number[number.Length - 1] == x);
        }
    }
}
