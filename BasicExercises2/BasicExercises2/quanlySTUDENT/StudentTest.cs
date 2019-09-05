using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace BasicExercises2.quanlySTUDENT
{
    class StudentTest
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
                Console.WriteLine("Management Student");
                Console.WriteLine("1. Insert new Student");
                Console.WriteLine("2. View list of Student");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Please select an option from 1 to 4");
                Console.Write("Option: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option >= 5 || option <= 0);
            Process(option);
        }

        public static void Process(int select)
        {
            Console.Clear();
            switch(select)
            {
                case 1:
                    {
                        CreateNew();
                        break;
                    }
                case 2:
                    {
                        DisplayStudent();
                        break;
                    }
                case 3:
                    {
                        var name = Console.ReadLine();
                        searchPhone(name);
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

        public static void CreateNew()
        {
            var student = new Student();
            Id = Id + 1;
            student.ID = Id;
            Console.WriteLine("Please input the FullName: ");
            student.FullName = Console.ReadLine();
            Console.WriteLine("Please input the DateofBirth: ");
            student.DateofBirth = Console.ReadLine();
            Console.WriteLine("Please input the Native: ");
            student.Native = Console.ReadLine();
            Console.WriteLine("Please input the Class: ");
            student.Class = Console.ReadLine();
            Console.WriteLine("Please input the PhoneNo: ");
            student.PhoneNo = Console.ReadLine();
            Console.WriteLine("Please input the Mobile: ");
            student.Mobile = int.Parse(Console.ReadLine());

            StudentList.Add(student);
        }

        public static void DisplayStudent()
        {
            foreach(Student item in StudentList)
            {
                item.Display();
            }
        }

        public static void searchPhone(string name)
        {
            if (StudentList != null)
            {
                foreach (Student item in StudentList)
                {
                    if (item.FullName == name)
                    {
                        item.Display();
                        break;
                    }
                }
            }
        }
    }
}
