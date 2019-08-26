using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.quanlySTUDENT
{
    class Student : IStudent
    {
        public string FullName { get; set; }
        public int ID { get; set; }
        public string DateofBirth { get; set; }
        public string Native { get; set; }
        public string Class { get; set; }
        public string PhoneNo { get; set; }
        public int Mobile { get; set; }

        public int[] itemStudent = new int[7];  // mảng này ko cần tạo cug đc khi nào cần tính trung bình + thì mới cần tạo mảng này.
        public void Display()
        {
            Console.WriteLine("FullName: {0}, ID: {1}, DateofBirth: {2}, Native:{3}, Class: {4}, PhoneNo: {5}, Mobile: {6}"
                ,FullName,ID, DateofBirth, Native, Class, PhoneNo, Mobile);
        }


    }
}
