using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt26
    {
        static void Main()
        {
            Console.Write("\nSum of the first 500 prime numbers: ");
            int sum = 0;
            int a = 0;
            int n = 2;
            while (a < 500)
            {
                if (isPrime(n))
                {
                    sum += n;
                    a++;
                }
                n++;
            }
            Console.WriteLine(sum);
        }
        static bool isPrime(int number)
        {
            if (number == 0 || number == 1)
                return false;
            
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)                
                    return false;                   
            }
            return true;
        }
    }
}
