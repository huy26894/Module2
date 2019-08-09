using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt12
    {
        static void Main()
        {
            int number;
            Console.Write(" Enter a digit : ");
            number = int.Parse(Console.ReadLine());
            Console.Write(number);
            Console.Write(" ");
            Console.Write(number);
            Console.Write(" ");
            Console.Write(number);
            Console.Write(" ");
            Console.Write(number);
            Console.WriteLine(" ");
            Console.Write(number);
            Console.Write(number);
            Console.Write(number);
            Console.WriteLine(number);
            Console.WriteLine("{0} {0} {0} {0}", number);
            Console.WriteLine("{0}{0}{0}{0}", number);
            Console.ReadKey();
        }
    }
}
