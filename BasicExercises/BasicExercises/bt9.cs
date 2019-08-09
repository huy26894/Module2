using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt9
    {
        static void Main()
        {
            double number1, number2, number3, number4, result;
            Console.WriteLine("\nInput the First number : ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInput the Second number : ");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInput the Third number : ");
            number3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInput the Four number : ");
            number4 = Convert.ToDouble(Console.ReadLine());
            result = (number1 + number2 + number3 + number4)/4;
            Console.WriteLine("\nThe average of the four numbers is : ");
            Console.Write("({0}+{1}+{2}+{3})/4={4}", number1, number2, number3, number4, result);
            Console.ReadKey();
        }
    }
}
