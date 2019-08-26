using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.baitap1
{
    public abstract class Animal
    {
        private string name;   // khai báo thuộc tính
        private string mauLong;
        private string soChan;

        public abstract void BietBay();
        public Animal()          // khai báo contructor là không cần khai báo kiểu dữ liệu trả về
        {

        }
        
        public Animal(string Name, string MauLong, string SoChan)
        {
            name =  Name; 
            mauLong = MauLong;
            soChan = SoChan;
        }

        public string Name { get => name; set => name = value; }
        public string MauLong { get => mauLong; set => mauLong = value; }
        public string SoChan { get => soChan; set => soChan = value; }
    }
}
