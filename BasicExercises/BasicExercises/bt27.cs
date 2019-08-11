using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt27
    {
        static void Main()
        {
            
                int sum = 0;
                Console.WriteLine("Please enter the number:");
                string number = Console.ReadLine();
                foreach (char c in number)
                {            
                    sum += int.Parse(c.ToString());              
                }

                Console.WriteLine("Sum of digits in number {0} is {1}", number, sum);
                Console.ReadKey();
           
        }
    }
}
