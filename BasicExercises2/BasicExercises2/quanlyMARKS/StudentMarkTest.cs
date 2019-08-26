using System;
using System.Collections.Generic;
using System.Text;
using BasicExercises2.quanlyMARKS.Model;

namespace BasicExercises2.quanlyMARKS
{
    public class StudentMarkTest
    {
        public static StudentMark studentMark = new StudentMark();
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
            switch(select)
            {
                case 1:
                    {
                        Id = Id + 1;
                        CreatNew();
                        break;
                    }
                case 2:
                    {
                        studentMark.Display();
                        break;
                    }
                case 3:
                    {
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
            studentMark.id = Id;
            Console.Write("Please input student fullname: ");
            studentMark.fullName = Console.ReadLine();
            Console.Write("Please input class name: ");
            studentMark.class1 = Console.ReadLine();
            Console.Write("Please input semester: ");
            studentMark.semester = int.Parse(Console.ReadLine());
            for(int i = 0; i < studentMark.SubjecMarkList.Length; i++)
            {
                Console.Write("Please input marks of subject " + (i + 1) + ":");
                studentMark.SubjecMarkList[i] = int.Parse(Console.ReadLine());
            }
            studentMark.InsertMark(Id);

        }
    }
}
