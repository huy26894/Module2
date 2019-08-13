using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt50
    {
        static void Main()
        {
            int[] nums = { 1, 2, 8 };
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
            
            for (var i = 0; i < nums.Length - 1; i++)
            {
                var temp = nums[i];
                nums[i] = nums[i + 1];
                nums[i + 1] = temp;
            }
           
            Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums));
        }
    }
}
