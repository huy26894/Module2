using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt21
    {
        static void Main()
        {
            int a, b;
            Console.Write(" Input the first number : ");
            a = int.Parse(Console.ReadLine());
            Console.Write(" Input the second number : ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine((a == 20 || b == 20) || (a + b == 20));
            Console.ReadKey();
        }
    }
}
