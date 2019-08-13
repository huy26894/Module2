using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt42
    {
        static void Main()
        {
            Console.Write("Enter the String : ");
            string str = Console.ReadLine();
            if (str.Length <= 3)          
                Console.WriteLine(str.ToUpper());       
            else
                Console.WriteLine(str.Substring(0, 4).ToLower() + str.Substring(4, str.Length - 4));
           
        }
    }
}
