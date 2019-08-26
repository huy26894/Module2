using System;
using System.Collections.Generic;
using System.Text;


namespace BasicExercises2.baitap2
{
    public class NewsTest
    {
        public static News news = new News();
        public static int Id = 0;
        public static void Main()
        {
            DrawMenu();    
        }
        public static void DrawMenu()            // tạo hàm vẽ list menu.

        {
            int option = 0;
            do
            {
                Console.WriteLine("Management News");
                Console.WriteLine("1. Insert news");
                Console.WriteLine("2. View list news");
                Console.WriteLine("3. Average rate");
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
        public static void Process(int selected)
        {
            switch (selected)
            {
                case 1:
                    {
                        Console.WriteLine("Insert news ....");
                        Id = Id + 1;
                        CraeteNews();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("View list news ....");
                        news.Display();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Average rate ....");
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
        public static void CraeteNews()
        {
            news.Id = Id;
            Console.WriteLine("Input title:");
            news.Title = Console.ReadLine();

            Console.Write("Input publish date:");
            news.PublishDate = Console.ReadLine();

            Console.Write("Input author:");
            news.Author = Console.ReadLine();

            Console.Write("Input content:");
            news.Content = Console.ReadLine();

            Console.WriteLine("Input rate:");
            for(int i=0; i<news.RateList.Length; i++)
            {
                Console.Write("Input rate{0}", i + 1);
                news.RateList[i] = int.Parse(Console.ReadLine());
            }

            news.InsertNews(Id);
            
        }
    }
}
