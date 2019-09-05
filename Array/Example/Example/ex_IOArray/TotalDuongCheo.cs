using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Example.ex_IOArray
{
    public class TotalDuongCheo
    {
        public static void Main()
        {
            Console.WriteLine("Input amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            int[,] Array = new int[amount, amount];
            for (int i = 0; i < amount; i++)
            {
                for (int j = 0; j < amount; j++)
                {
                    Console.WriteLine($"Nhap phan tu thu Array[{i}][{j}]");
                    Array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            WriteArray(amount, Array);
            ReadandWrite(amount); // gọi hàm
        }

        public static void WriteArray(int amount, int[,] Array)
        {
            FileStream file = new FileStream($"D:\\Module2\\Array\\Example\\ArrInput.txt", FileMode.Create);
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(amount);
                for (int i = 0; i < amount; i++)
                {
                    for (int j = 0; j < amount; j++)
                    {
                        writer.Write($"{Array[i, j]} ");
                    }
                    writer.WriteLine();
                }
            }
            file.Close();
        }

        public static void ReadandWrite(int amount)
        {
            int[,] ArrayNumber = new int[amount, amount];
            int SumDiagonal = 0;    // đường chéo chính
            int SumDiaonalTemp = 0; // đường chéo phụ
            int EvenNumber = 0;
            int PrimeNumber = 0;
            int temp = 0;   // biến này để tính số nguyên tố
            FileStream file = new FileStream($"D:\\Module2\\Array\\Example\\ArrInput.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                int index = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (index == 0)
                    {
                        index++;
                        continue;
                    }

                    line = line.Trim();
                    var ArrayTemp = line.Split(" ");
                    for (int i = 0; i < ArrayTemp.Length; i++) //do mình bo qua hàng đầu nên 
                    {                                          //index đã nhảy lên 1 nên các câu sau phải trừ đi 1
                        ArrayNumber[index - 1, i] = Convert.ToInt32(ArrayTemp[i]);
                        if ((index - 1) == i)
                        {
                            SumDiagonal += ArrayNumber[index - 1, i];
                        }
                        if ((index - 1 + i) == ArrayTemp.Length - 1)
                        {
                            SumDiaonalTemp += ArrayNumber[index - 1, i];
                        }
                        if (ArrayNumber[index - 1, i] % 2 == 0)
                        {
                            EvenNumber++;
                        }
                        if (ArrayNumber[index - 1, i] >= 2) // xét phần tử ở mảng trên có lớn hơn 2 rồi mới xét
                        {

                            for (int k = 2; k <= Math.Sqrt(ArrayNumber[index - 1, i]); k++)
                            {
                                if (ArrayNumber[index - 1, i] % k == 0)
                                {
                                    temp++;
                                }

                            }
                            if (temp == 0)
                            {
                                PrimeNumber++;
                            }
                            temp = 0;
                        }
                    }
                    index++;
                }
                file.Close();
            }
            FileStream file1 = new FileStream($"D:\\Module2\\Array\\Example\\ArrOutput.txt", FileMode.Create);
            using (StreamWriter writer = new StreamWriter(file1))
            {
                writer.WriteLine($"Tổng đường chéo chính A: {SumDiagonal}");
                writer.WriteLine($"Tổng đường chéo phụ B: {SumDiaonalTemp}");
                writer.WriteLine($"Có {EvenNumber} số chẵn");
                writer.WriteLine($"Có {PrimeNumber} số nguyên tố");
            }

        }
    }
}
