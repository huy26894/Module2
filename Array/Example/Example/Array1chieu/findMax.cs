using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Array1chieu
{
    public class findMax
    {
        public static int[] array = { 5, 2, 8, 9, 4 };
        
        public static void Main()
        {
            Console.WriteLine("Array : [{0}]", string.Join(",", array));
            FindMax();
            FindMin();
            Reverse();
            
        }

        public static void FindMax()
        {          
            var max = array[0];
            for (int i=0; i<array.Length; i++)
            {
                if(max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Number max of array: {0}",max);
        }

        public static void FindMin()
        {          
            var min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Number min of array: {0}", min);
        }

        public static void Reverse()
        {
            int first = 0;
            int last = array.Length - 1;
            while(first<last)
            {
                int temp = array[first];
                array[first] = array[last];
                array[last] = temp;
                first++;
                last--;
            }
            Console.WriteLine("Array reverse: [{0}]", string.Join(",", array));
        }      
    }
}
