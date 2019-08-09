using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt14
    {
        static void Main()
        {
            int c, Kelvin, Fahrenheit;
            Console.Write(" Enter the amount of celsius: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine(" Expected Output: ");
            Console.WriteLine("Kelvin = {0}",c + 273);
            Console.WriteLine("Fahrenheit = {0}", c * 18 / 10 + 32);
            Console.ReadKey();
        }
    }
}
