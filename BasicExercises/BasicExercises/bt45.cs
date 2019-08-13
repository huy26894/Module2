using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace BasicExercises
{
    class bt45
    {
        static void Main()
        {
            Console.WriteLine("Input an integer: ");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();          
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals('5'))
                    count++;
            }
            Console.WriteLine(count);

            /*Console.WriteLine("\nInput an integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            Console.WriteLine("Number of " + x + " present in the said array:");
            Console.WriteLine(nums.Count(n => n == x));*/  // muốn use ph thức Count thì pải thêm using System.Linq 
        }
    }
}
