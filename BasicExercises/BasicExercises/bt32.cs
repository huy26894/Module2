using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt32
    {
       static void Main()
        {
            
            Console.Write("Input the Number : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 3 == 0 || number % 7 == 0);
            Console.ReadKey();
        }
       
        
    }
}
