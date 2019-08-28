using System;
using System.Collections.Generic;
using System.Text;

namespace Example.TestArray2chieu
{
    public class Test
    {
        public static int[,] array =
        {
            { 1, 2, 3},
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        public static void Main()
        {
            Array();
            FindMax();
            FindMin();
            //Reverse();
        }

        public static void Array()
        {
            Console.WriteLine("Array : ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");                   
                }
                Console.WriteLine();
            }           
        }

        public static void FindMax()
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j]) ;
                    max = array[i, j];
                }
            }
            Console.WriteLine("Value max in array : " + max);
        }

        public static void FindMin()
        {
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    min = array[i, j];
                }
            }
            Console.WriteLine("Value min in array : " + min);
        }

        /*public static void Reverse()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int temp = array[i, j];
                    array[i, j] = array[array.GetLength(0) - 1, array.GetLength(1) - 1];
                    array[array.GetLength(0) - 1, array.GetLength(1) - 1] = temp;
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(string.Join(",",array));
            
        }*/
    }
}
