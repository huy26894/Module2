using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt28
    {
        static void Main()
        {

            string str = "Display the pattern like pyramid using the alphabet";
            var array = str.Split(' ');
            Console.WriteLine(str);
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadKey();

        }
    }
}
