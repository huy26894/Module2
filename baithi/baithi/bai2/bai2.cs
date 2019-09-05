using System;
using System.Collections.Generic;
using System.Text;

namespace baithi.bai2
{
    public class bai2
    {
        public static int[] Array;
        public static void Main()
        {
            InitMenu();
            InitArray();
        }
        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("Menu :");
                Console.WriteLine("1. Tao Mang");
                Console.WriteLine("2. Kiem tra mang tang");
                Console.WriteLine("3. Sap xep mang");
                Console.WriteLine("4. Tim kiem mang");
                Console.WriteLine("5. Thoat");
                Console.WriteLine("Please select an option from 1 to 5");
                Console.Write("Option: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option >= 6 || option <= 0);
            Process(option);
        }
        public static void Process(int select)
        {
            Console.Clear();
            switch (select)
            {
                case 1:
                    {
                        Console.WriteLine("Tao Mang .....");
                        InitArray();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Kiem Tra Mang Tang ................");
                        if (IsIncreaseArray(Array))
                        {
                            Console.WriteLine(true);
                            break;
                        }
                        else
                        {
                            Console.WriteLine(false);
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Sap Xep Mang .....");
                        SelectionSort(Array);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Tim Kiem Mang .....");
                        Console.WriteLine("Input number ");
                        int n;
                        do
                        {
                            int.TryParse(Console.ReadLine(), out n);
                            Console.WriteLine("Input number ");
                        }
                        while (n <= 0);
                        if (Find(Array, n) == -1)
                        {
                            Console.WriteLine("Not find");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Number position to search for: {0}", string.Join(",", Find(Array, n)));
                        }
                        break;
                        
                    }
                case 5:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            InitMenu();
        }

        public static void InitArray()
        {
            Console.Write("Input the index of Array: ");
            int index = int.Parse(Console.ReadLine());

            int[] array = new int[index];
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Input item Array[{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array :");
            for (int i = 0; i < array.Length; i++)
            {                         
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static bool IsIncreaseArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1]) return false;
            }
            return true;
        }
        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                var min = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        var tem = array[i];
                        array[i] = array[j];
                        array[j] = tem;
                    }
                }
            }
            Show(Array);
            Console.WriteLine();
            Console.WriteLine("---------------------");
        }
        public static int Find(int[] array, int n)
        {
            int min = 0;
            int max = array.Length - 1;
            int mid = 0;
            while (min <= max)
            {
                mid = (max + min) / 2;
                if (array[mid] == n)
                {
                    return mid;
                }
                else if (array[mid] < n)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return -1;
        }
        public static void Show(int[] Array)
        {
            foreach (int item in Array)
            {
                Console.Write("{0}", item);
            }
        }
        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
