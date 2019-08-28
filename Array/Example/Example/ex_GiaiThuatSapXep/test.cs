using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example.exSort_Chọn_selection_
{
    public class test
    {
        public static int[] array = { 5, 5, 2, 8, 9, 4, 10 , 1, -3, 7, 11};
        public static void Main()
        {
            Console.WriteLine(string.Join(",", array));
            SeletionSort();
            InsertionSort();
            BubbleSort();
            //QuickSort(0,array.Length-1); 
            
        }
        public static void SeletionSort()  // sắp xếp chọn
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                var min = array[i];
                var pos = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        pos = j;
                    }
                }
                var temp = array[i];
                array[i] = array[pos];
                array[pos] = temp;
            }
            Console.WriteLine("Mang sap xep tang dan theo selection sort la: " + String.Join(",", array));
        }

        public static void InsertionSort()  // sắp xếp chèn
        {
            int pos, x;
            for (int i = 1; i < array.Length; i++)
            {
                x = array[i];
                pos = i - 1;
                while ((pos >= 0) && (array[pos] > x))
                {
                    array[pos + 1] = array[pos];
                    pos--;
                }
                array[pos + 1] = x;
            }
            Console.WriteLine("Mang sap xep tang dan theo insertion sort la: " + String.Join(",", array));
        }

        public static void BubbleSort()  // sắp xếp nổi bọt
        {
            int n = array.Length;
            for(int i = 0; i < n -1; i++)
            {
                for(int j = n-1; j>i; j--)
                {
                    if(array[j] < array[j-1])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }                     
                }
            }
            Console.WriteLine("Mang sap xep tang dan theo bubble sort la: " + String.Join(",", array));
        }

        /*public static void QuickSort(int left, int right)
        {

            int i = left;
            int j = right;
            int pivot = array[(left + right) / 2];

            while(i < j)
            {
                while (array[i] < pivot)
                    i++;
                while (array[j] > pivot)
                    j--;
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            if (left < j)
                QuickSort(left, j);
            if (i < right)
                QuickSort(i, right);

            Console.WriteLine("Mang sap xep tang dan theo quick sort la: " + String.Join(",", array));

        }*/
        
    }
}
