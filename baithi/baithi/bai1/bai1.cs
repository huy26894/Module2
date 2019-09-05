using System;
using System.Collections.Generic;
using System.Text;

namespace baithi.bai1
{
    public class bai1
    {
        public static void Main()
        {
            int n = InputSize("row");
            int m = InputSize("column");
            int[,] array = InitMatrix(n, m);
            ShowMaxRow(array);

        }
        public static int InputSize(string a)
        {
            int size = -1;
            do
            {
                Console.Write("Input {0}: ", a);
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    size = number;
                }
            }
            while (size <= 0);
            return size;
        }
        /*public static void InitMatrix()
        {
            Console.Write("Input the row: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input the colum: ");
            int m = int.Parse(Console.ReadLine());

            int[,] array = new int[n, m];
            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("Input item Array[{0},{1}]: ", i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            Console.WriteLine("Array :");         
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");                 
                }
                Console.WriteLine();
            }
        }*/
        public static int[,] InitMatrix(int row, int column)
        {
            int[,] array = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    do
                    {
                        Console.Write("Input item Array[{0}, {1}]: ", i, j);
                        if (int.TryParse(Console.ReadLine(), out var number))
                        {
                            array[i, j] = number;
                            break;
                        }
                    }
                    while (true);
                }
            }     

            Console.WriteLine("Array :");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            return array;
            
        }
        public static int Sum(int[,] array, int row)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                sum += array[row, i];
            }
            return sum;
        }

        public static void ShowMaxRow(int[,] arr)
        {
            int maxRow = 0;
                for (int i = 1; i < arr.GetLength(0); i++)
                {
                    if (Sum(arr, i) > Sum(arr, maxRow))
                    {
                        maxRow = i;
                    }
                }
                Console.WriteLine("Value of Row Max: ");
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    Console.Write(arr[maxRow, i] + " ");
                }
        }
    }
}
