using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt20
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Result(28, 6));
            Console.WriteLine(Result(10, 30));
            Console.WriteLine(Result(15, 15));
            Console.WriteLine(Result(5, 47));
        }
        static int Result(int a ,int b)
        {
            if (a > b)
            {
                return (a - b) * 2;
            }
            else
                return b - a;
        }
    }
}
