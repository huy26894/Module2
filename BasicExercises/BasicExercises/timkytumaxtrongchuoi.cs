using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class timkytumaxtrongchuoi
    {
        static void Main()
        {
            var str = "abc abhda sdsj adksadnasl";
            string[] arr = str.Split(' ');
            var maxStr = arr[0];
            for (int i=1;i<arr.Length;i++)
            {
                if (maxStr.Length<arr[i].Length)
                {
                    maxStr = arr[i];
                }
            }
           
            Console.WriteLine(maxStr);
            Console.ReadKey();
        }
    }
}
