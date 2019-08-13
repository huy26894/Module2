using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BasicExercises
{
    class bt41
    {
        static void Main()
        {
            /*Console.Write("Input a string (conatins at least one 'w' char) : ");
            string str = Console.ReadLine();
            var count = str.Count(s => s == 'w');
            Console.WriteLine("Test the string contains 'w' character  between 1 and 3 times: ");
            Console.WriteLine(count >= 1 && count <= 3);*/

            Console.WriteLine("Enter a string : ");
            string str = Console.ReadLine();
            char[] arr;
            arr = str.ToCharArray();

            int counter = 0;

            foreach (char c in arr)
                if (c == 'w')
                {
                    counter++;
                }
            Console.WriteLine("Test the string contains 'w' character between 1 and 3 times: ");
            Console.WriteLine(counter >= 1 && counter <= 3);
        }
    }
}
