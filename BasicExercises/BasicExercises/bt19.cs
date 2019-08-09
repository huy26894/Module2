using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt19
    {
        static void Main(string[] args)
        {
            /*int a, b, c;
            Console.Write(" Input the Fisrt Number : ");
            a = int.Parse(Console.ReadLine());
            Console.Write(" Input the Second Number : ");
            b = int.Parse(Console.ReadLine());
            c = a + b;
           
            if (a == b)
            {
                Console.WriteLine("\nThe sum of two numbers is :\n" + 3 * c);
            } else
            {
                Console.WriteLine("\nThe sum of two numbers is :\n{0} + {1} = {2}", a, b, c);
            }*/
            Console.WriteLine(SumTriple(5, 6));
            Console.WriteLine(SumTriple(5, 5));
            
        }
        static int SumTriple(int a, int b)
        {
            return a == b ? 3 * (a + b) : a + b;
        }
    }
}
