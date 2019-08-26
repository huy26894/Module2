using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace BasicExercises2.quanlyMARKS_ver2
{
    public class StudentTest
    {
        public static ArrayList StudentList = new ArrayList();
        public static int Id = 0;
        public static void Main()
        {
            DrawMenu();
        }

        public static void DrawMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("1. Insert new Student...");
                Console.WriteLine("2. View list of  Student...");
                Console.WriteLine("3. Average Mark...");
                Console.WriteLine("4. Exit");
                Console.Write("Option: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option > 5 || option <= 0);
            Process(option);
        }
        public static void Process(int select)
        {
            Console.Clear();
            switch (select)
            {
                case 1:
                    {                      
                        CreatNew();
                        break;
                    }
                case 2:
                    {                      
                        DisplayStudent();                       
                        break;
                    }
                case 3:
                    {
                        AverageStudentMark();
                        break;
                    }
                case 4:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            DrawMenu();
        }

        public static void CreatNew()
        {
            var student = new StudentMark();
            Id = Id + 1;
            student.Id = Id;
            Console.Write("Please input student fullname: ");
            student.FullName = Console.ReadLine();
            Console.Write("Please input class name: ");
            student.Class1 = Console.ReadLine();
            Console.Write("Please input semester: ");
            student.Semester = int.Parse(Console.ReadLine());
            for (int i = 0; i < student.SubjecMarkList.Length; i++)
            {
                Console.Write("Please input marks of subject " + (i + 1) + ":");
                student.SubjecMarkList[i] = int.Parse(Console.ReadLine());
            }

            StudentList.Add(student);
        }
        public static void DisplayStudent()
        {
            foreach (StudentMark student in StudentList)
            {
                Console.WriteLine(student.Display());
            }
        }
        public static void AverageStudentMark()
        {
            foreach (StudentMark student in StudentList)
            {
                student.AveCal();
            }
        }
    }
}
