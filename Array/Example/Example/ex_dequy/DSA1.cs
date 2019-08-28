using System;
using System.Collections.Generic;
using System.Text;

namespace Example.ex_dequy
{
    public class DSA1
    {
        public static void Main()
        {
            Console.Write("Input n = ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", n, GiaiThua(n));
        }

        public static long GiaiThua(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }               
            return n * GiaiThua(n - 1);
        }
    }
}
