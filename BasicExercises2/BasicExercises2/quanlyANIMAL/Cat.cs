using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.baitap1
{
    public class Cat : Animal
    {
        private string mauMat;
        private string tenChuNhan;

        public string MauMat { get => mauMat; set => mauMat = value; }
        public string TenChuNhan { get => tenChuNhan; set => tenChuNhan = value; }

        public Cat()
        {

        }

        public Cat(string Name, string MauLong, string SoChan, string MauMat, string TenChuNhan) : base (Name,MauLong,SoChan)
        {
            mauMat = MauMat;
            tenChuNhan = TenChuNhan;
        }

        public void Xuat()
        {
            Console.WriteLine("Meo {0} cua {1} co long {2}", Name, TenChuNhan, MauLong);    
        }

        public override void BietBay()
        {
            Console.WriteLine("Meo khong biet bay");
        }
    }
}
