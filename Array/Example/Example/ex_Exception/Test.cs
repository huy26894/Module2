using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Example.ex_Exception
{
    public class Test
    {
        public static void Main()
        {
            FileStream file = new FileStream($"D:\\Module2\\Array\\Example\\log_{DateTime.Now.ToString("dd_MM_yyyy")}.txt", FileMode.Append);
            // nếu muốn cứ log có 1 file thì thêm (hh_mm_ss_tt) vào datetime còn chỉ muốn log trong 1 ngày thì xóa (hh_mm_ss_tt).
            try
            {
                Console.Write("Input a = ");
                var a = int.Parse(Console.ReadLine());
                Console.Write("Input b = ");
                var b = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            }
            catch (DivideByZeroException dze)
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine($"[Error]:{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")} : {dze.Message} ");
                }
                Console.Write("[Error]: " + dze.Message);
            }
            catch (FieldAccessException fil)
            {
                Console.Write("[Error]: " + fil.Message);
            }
            catch (Exception ex)    // bắt toàn bộ lỗi.
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine($"[Error]:{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")} : {ex.Message} ");
                }
                Console.Write("[Error]: " + ex.Message);
            }
            finally
            {
                Console.Write("go to finally");
            }

            file.Close();
            FileStream file1 = new FileStream($"D:\\Module2\\Array\\Example\\log_{DateTime.Now.ToString("dd_MM_yyyy")}.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(file1))
            {
                var content = reader.ReadToEnd();
                Console.Write(content);
            }
        }
    }   
}
