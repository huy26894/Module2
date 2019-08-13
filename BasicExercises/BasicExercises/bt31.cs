using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt31
    {
        static void Main()
        {
            string str;     
            Console.Write("Input a string : ");
            str = Console.ReadLine();
           
                Console.WriteLine(str.Length < 4 ? str: str.Substring(str.Length - 4) +
                str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
            
            Console.ReadLine();
        }
    }
}
