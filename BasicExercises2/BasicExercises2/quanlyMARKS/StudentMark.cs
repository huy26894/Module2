using System;
using System.Collections.Generic;
using System.Text;
using BasicExercises2.quanlyMARKS.Model;



namespace BasicExercises2.quanlyMARKS
{
    public class StudentMark : IStudentMark
    {
        public string fullName;  // khại báo thuộc tính.
        public int id;
        public string class1;
        public int semester;
        private double averageMark;
        public double AverageMark { get => averageMark; }
        /*public string FullName { get => fullName; set => fullName = value; }
        public int Id { get => id; set => id = value; }
        public string Class1 { get => class1; set => class1 = value; }
        public int Semester { get => semester; set => semester = value; }
        public double AverageMark { get => averageMark; }*/

        public void Display()
        {
            foreach(var markItem in ArrayList)
            {
                if(markItem != null)
                {
                    Console.WriteLine("FullName: {0}, ID: {1}, Class: {2}, Semester: {3}, AverageMark: {4}"
                        ,markItem.FullName,markItem.ID,markItem.Class1,markItem.Semester,markItem.AverageMark);
                }                
            }  
        }

        public int[] SubjecMarkList = new int[5];
        public MarkItem[] ArrayList = new MarkItem[10];

        

        public void AveCal()
        {
            var total = 0;
            for(int i=0; i<SubjecMarkList.Length; i++)
            {
                total += SubjecMarkList[i];
            }
            averageMark = (double)(total / SubjecMarkList.Length);
        }

        public void InsertMark(int index)
        {
            AveCal();
            var markItem = new MarkItem()
            {
                ID = id,
                FullName = fullName,
                Class1 = class1,
                Semester = semester,
                AverageMark = averageMark
            };
            ArrayList[index] = markItem;
        }
    }
}
