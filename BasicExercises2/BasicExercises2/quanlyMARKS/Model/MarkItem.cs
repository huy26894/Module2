using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.quanlyMARKS.Model
{
    public class MarkItem
    {
        public int ID { get; set; }   // tạo ra kiểu dữ liệu để dùng lưu vào mảng ArrayList.
        public string FullName { get; set; }
        public string Class1 { get; set; }
        public int Semester { get; set; }
        public double AverageMark { get; set; }
    }
}
