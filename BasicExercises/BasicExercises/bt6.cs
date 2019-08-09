using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt6
    {
        public static void Main()
        {
            int number1, number2, number3;
            Console.Write("\nInput the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Third Number : ");
            number3 = int.Parse(Console.ReadLine());
            Console.Write("Multiplication of three numbers : ");
            Console.Write(number1 * number2 * number3);
            Console.Read();
        }
    }
}
