using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt10
    {
        static void Main()
        {
            int number1, number2, number3, a, b;
            Console.WriteLine("\nInput the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInput the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInput the Third Number : ");
            number3 = int.Parse(Console.ReadLine());
            a = (number1 + number2)*number3;
            b = number1 * number2 + number2 * number3;
            Console.WriteLine("({0}+{1})x{2} = {3}", number1, number2, number3, a);
            Console.WriteLine("{0}x{1}+{2}x{3} = {4}", number1, number2, number2, number3, b);
            Console.ReadKey();
        }
    }
}
