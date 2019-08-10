using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt24
    {
        static void Main ()
        {
            Console.Write(" Enter a String : ");
            var str = Console.ReadLine();
            string[] arr = str.Split(' ');
            var maxStr = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (maxStr.Length < arr[i].Length)
                {
                    maxStr = arr[i];
                }
            }
            Console.WriteLine(string.Join(",", arr));
            Console.WriteLine(maxStr);
            Console.ReadKey();
        }
    }
}
