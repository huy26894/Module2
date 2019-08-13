using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt37
    {
        static void Main()
        {
            string str;
            Console.Write("Enter the String : ");
            str = Console.ReadLine();

            if (str.Substring(0, 2).Equals("HP"))
            {
                Console.WriteLine(str.Remove(0, 2));
            }
                   
        }
    }
}
