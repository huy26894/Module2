using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt18
    {
        static void Main()
        {
            int a, b;
            Console.Write("Input first integer: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input second integer: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(a > 0 && b < 0 || a < 0 && b > 0); // đk đúng thì nó tự in ra là true còn ngc lại thì fasle nên ko cần consolo dòng dưới nữa.
           /* {
                Console.WriteLine("True");      
            }*/
            Console.ReadKey();
        }
    }
}
