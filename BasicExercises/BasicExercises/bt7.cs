using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt7
    {
        public static void Main()
        {
            int num1, num2;
            Console.Write("\nInput the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
            /*Console.WriteLine("Plus two numbers : ");
            Console.WriteLine(number1 + number2);
            Console.WriteLine("Subtract two number : ");
            Console.WriteLine(number1 - number2);
            Console.WriteLine("Multiply two number : ");
            Console.WriteLine(number1 * number2);
            Console.WriteLine("Divide two number : ");
            Console.WriteLine(number1 / number2);
            Console.Read();*/
        }
    }
}
