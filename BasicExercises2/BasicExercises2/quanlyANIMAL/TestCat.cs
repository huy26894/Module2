using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.baitap1
{
    class TestCat
    {
      
        public static void Main()
        {
            var ConMeo = new Cat();
            ConMeo.Name = "Kitty";          
            ConMeo.MauLong = "mau Trang";
            ConMeo.SoChan = "co 4 chan";
            ConMeo.MauMat = "mau Nau";
            ConMeo.TenChuNhan = "Nguyen Van A";
            ConMeo.Xuat();

            Console.ReadKey();
           

        }
    }
}
