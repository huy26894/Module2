using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class daonguocmang
    {
        static void Main()
        {
            int[] number = new int[] { 1, 2, 3, 4, 5 };
            int first = 0;
            int last = number.Length - 1;
            while (first < last)
            {
                int temp;

                temp = number[first];
                number[first] = number[last];
                number[last] = temp;
                first++;
                last--;
            }
            /*for(int i=0;i<number.Length;i++)
            {
               
                Console.WriteLine(number[i]);
            }*/
            foreach (int item in number)
            {
                Console.WriteLine(item);
            }
        }
    }
}
