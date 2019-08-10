using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt22
    {
        static void Main(string[] args)
        {           
            Console.Write("Input the Number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(result(a));         
        }
        static bool result(int n)
        {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
                return true;
                return false;          
        }    
    }
}
