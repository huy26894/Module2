using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt44
    {
        static void Main()
        {
            Console.Write("Input a string : ");
            string str = Console.ReadLine();
            /*var result = "";
            for (int i = 0; i < str.Length; i ++)  
            {
                if (i % 2 == 0) result += str[i];
            }
            Console.WriteLine(result);*/
            string m= "";
            for (int i = 1; i < str.Length; i = i + 1)
            {
               m= str.Remove(i, 1);
                str = m;               
            }           
            Console.WriteLine(str);
        }
    }
}
