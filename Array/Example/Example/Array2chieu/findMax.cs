using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Array2chieu
{
    public class findMax
    {
        public static void Main()
        {  
            // set số dòng và số cột cho mảng
            Console.Write("Input the row: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Input the colum: ");
            int colum = int.Parse(Console.ReadLine());

            int[,] array = new int[row, colum];
            Console.WriteLine();

            // set giá trị tại từng dòng và từng cột cho mảng
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("Input item Array[{0},{1}]: ", i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            // xuất mảng đã nhập và tính tổng giá trị của mảng ra màn hình
            Console.WriteLine("Array :");
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                    sum = sum + array[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Total values in array : " + sum);

            // tìm giá trị lớn nhất trong mảng
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {                    
                    if (max < array[i, j])
                        max = array[i, j];
                }                   
            }
            Console.WriteLine("Value max in array : " + max);

            // tìm giá trị nhỏ nhất trong mảng
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

            int sum1 = 0;
            //for (int i = 0; i < array.GetLength(0); i++)          // cách duyệt = 2 vòng for.
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (i == j)
            //            sum1 = sum1 + array[i, j];
            //    }
            //}
            int m1 = array.GetLength(0);
            for (int i = 0; i < m1; i++)                        // cách duyệt = 1 vòng for.
            {
                sum1 += array[i, i];
            }
            Console.WriteLine("Tong duong cheo chinh la : " + sum1);

            int sum2 = 0;
           /* for (int i = 0; i<array.GetLength(0) ; i++)
            {
                for (int j = array.GetLength(1)-1; j>=0; j--)
                {
                    if (i == j)
                        sum2 = sum2 + array[i, j];
                }
            }*/

            int m = array.GetLength(0);
            for (int i = 0; i < m; i++)
            {
                sum2 += array[i, m - 1 - i];
            }
            Console.WriteLine("Tong duong cheo phu la : " + sum2);
        }     
       
    }
}
