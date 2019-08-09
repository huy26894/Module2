using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt8
    {
        static void Main()
        {
            int number,i;
            Console.WriteLine("\nInput the number : ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("\nExpected Output : ");
            for(i=0;i<10;i++)
            {
                Console.WriteLine("{0} * {1} = {2}" , number,i , number*i);
            }
            Console.ReadKey();
        }
    }
}
