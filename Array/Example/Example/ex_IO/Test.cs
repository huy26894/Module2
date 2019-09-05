using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Example.ex_IO
{
    public class Test
    {
        public static void Main()
        {
            CreateWrite();
            Read();
        }
        public static void CreateWrite()
        {
            FileStream fileName = new FileStream($"D:\\Module2\\Array\\Example\\input.txt", FileMode.Create);
            Console.Write("Input size of Array:  ");
            int n = int.Parse(Console.ReadLine());
            int[] Array = new int[n];
            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("Enter element {0} of the array:  ", i + 1);
                Array[i] = int.Parse(Console.ReadLine());
            }

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(n);
                writer.WriteLine("{0}", string.Join(" ", Array));
            }
            fileName.Close();

        }
        public static void Read()
        {
            string[] ArrayString = null;
            int sumNumber = 0;
            FileStream file = new FileStream($"D:\\Module2\\Array\\Example\\input.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(file))
            {
                int index = 1;
                string line;

                while ((line = reader.ReadLine()) != null)   // line = reader.ReadLine() là đọc theo từng dòng.
                {
                    if (index == 1)
                    {
                        index++;
                        continue;
                    }
                    ArrayString = line.Split(" ");
                    int sum = 0;
                    for (int i = 0; i < ArrayString.Length; i++)
                    {
                        sum += int.Parse(ArrayString[i]);
                    }
                    sumNumber = sum;
                }
            }
            file.Close();

            FileStream output = new FileStream($"D:\\Module2\\Array\\Example\\output.txt", FileMode.Create);
            int[] ArrayMod2 = new int[10];
            for (int i = 0; i < ArrayString.Length; i++)
            {
                if (int.Parse(ArrayString[i]) % 2 == 0)
                {
                    ArrayMod2[i] = int.Parse(ArrayString[i]);
                }
            }

            for (int i = 0; i < ArrayString.Length; i++)
            {
                for (int j = ArrayString.Length - 1; j > i; j--)
                {
                    if (int.Parse(ArrayString[j]) < int.Parse(ArrayString[j - 1]))
                    {
                        var temp = ArrayString[j];
                        ArrayString[j] = ArrayString[j - 1];
                        ArrayString[j - 1] = temp;
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(output))
            {
                writer.WriteLine($"Tong gia tri {sumNumber}");
                writer.Write("Cac so chan la : ");
                for (int i = 0; i < ArrayMod2.Length; i++)
                {
                    if (ArrayMod2[i] != 0)
                    {
                        writer.Write($"{ArrayMod2[i]}");
                    }
                }
                writer.WriteLine($"Array Sort: {string.Join(" ", ArrayString)}");
            }
        }
    }
}
