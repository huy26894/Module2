using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt39
    {
        static void Main()
        {
            Console.Write("Input the First Number : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input the Second Number : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Input the Third Number : ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Largest of three: " + Math.Max(a, Math.Max(b, c)));
            Console.WriteLine("Lowest of three: " + Math.Min(a, Math.Min(b, c)));
            /*if (a > b && a > c)
            {
                Console.WriteLine("Largest of three : " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Largest of three : " + b);
            }
            else
                Console.WriteLine("Largest of three : " + c);

            if (a < b && a < c)
            {
                Console.WriteLine("Lowest of three : " + a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("Lowest of three : " + b);
            }
            else
                Console.WriteLine("Lowest of three : " + c);
*/

        }
    }
}
