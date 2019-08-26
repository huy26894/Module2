using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.baitap3
{
    public class BookTest
    {
        public static Book books = new Book();
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
                Console.WriteLine("Management Book");
                Console.WriteLine("1. Insert new book");
                Console.WriteLine("2. View list of books");
                Console.WriteLine("3. Average Price");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Please select an option from 1 to 4");
                Console.Write("Option: ");
                if(int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option > 4 || option <= 0);
            Process(option);
        }

        public static void Process(int select)
        {
            switch(select)
            {
                case 1:
                    {
                        Console.WriteLine("Insert new book ...");
                        Id = Id + 1;
                        CreatBook();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("View list of book ...");
                        books.Display();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Average Price ...");
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

        public static void CreatBook()
        {
            books.Id = Id;
            Console.WriteLine("Input Name:");
            books.Name = Console.ReadLine();

            Console.WriteLine("Input the PublishDate:");
            books.PublishDate = Console.ReadLine();

            Console.WriteLine("Input the Author:");
            books.Author = Console.ReadLine();

            Console.WriteLine("Input the Language:");
            books.Language = Console.ReadLine();

            Console.WriteLine("Input price:");
            for (int i=0; i < books.PriceList.Length; i++)
            {
                Console.WriteLine(" + Input price{0}", i + 1);
                books.PriceList[i] = int.Parse(Console.ReadLine());
            }
            books.InsertBook(Id);

        }
    }
}
