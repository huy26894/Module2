using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.quanlyMARKS_ver2
{
    public class StudentMark : IStudentMark
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Class1 { get; set; }
        public int Semester { get; set; }

        public float AverageMark { get; private set; }

        public int[] SubjecMarkList = new int[5];
        public string Display()
        {
            return $"Id: {Id}, FullName: {FullName}, Class: {Class1}, Semester: {Semester}, AverageMark: {AverageMark}";
           
        }

        public void AveCal()
        {
            var total = 0;
            for (int i = 0; i < SubjecMarkList.Length; i++)
            {
                total += SubjecMarkList[i];
            }
            AverageMark = (float)(total / SubjecMarkList.Length);
        }

    }
}
