using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace BasicExercises
{
    class bt61
    {
        public static int[] sort_numbers(int[] arra)
        {

            int[] num = arra.Where(x => x != -5).OrderBy(x => x).ToArray();
            int ctr = 0;

            return arra.Select(x => x >= 0 ? num[ctr++] : -5).ToArray();
        }

        public static void Main()
        {
            int[] x = sort_numbers(new int[] { -5, 236, 120, 70, -5, -5, 698, 280 });
            foreach (var item in x)
            {
                Console.WriteLine(item.ToString());
            }
        }
        
    }
}
