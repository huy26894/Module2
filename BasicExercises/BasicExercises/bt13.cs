using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt13
    {
        static void Main()
        {
            int number;
            Console.Write(" Enter a number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(" Expected Output: ");
            Console.WriteLine("{0}{0}{0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0}{0}{0}", number);
            Console.ReadKey();
        }
    }
}
