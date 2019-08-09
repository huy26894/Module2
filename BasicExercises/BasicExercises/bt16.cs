using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt16
    {
        static void Main(string[] args)
        {
            Console.WriteLine(first_last("w3resource"));
            Console.WriteLine(first_last("Python"));
            Console.WriteLine(first_last("x"));
        }
        static string first_last(string str)
        {
            return str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }
        
    }
}
