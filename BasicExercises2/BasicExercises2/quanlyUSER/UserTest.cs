using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.quanlyUSER
{
    public class UserTest
    {
        public static Dictionary<int, User> PhoneList = new Dictionary<int, User>();
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
                Console.WriteLine("Management Users");
                Console.WriteLine("1. Add Users");
                Console.WriteLine("2. Check Users");
                Console.WriteLine("3. Display all Users");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Please select an option from 1 to 4");
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
                        Console.WriteLine("Add Users ...");
                        CreateNew();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Check Users ...");
                        
                        CheckkUser();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Display all Users ...");
                        Display();
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
            User user = new User();
            Id = Id + 1;
            user.ID = Id;
            Console.Write("Please input the FullName: ");
            user.Name = Console.ReadLine();
            Console.Write("Please input the Password: ");
            user.Password = Console.ReadLine();    
            var number = 0;
            do
            {   
                Console.Write("Input PhoneList: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number > 0)
                        user.phoneList.Add(number);
                };
            }
            while (number > 0);     
            PhoneList.Add(Id,user);
        }

        public static void CheckkUser()
        {
            Console.Write("Please input user name: ");
            var name = Console.ReadLine();
            Console.Write("Please input user passwork: ");
            var passwork = Console.ReadLine();

            var isExits = false;
            foreach (KeyValuePair<int, User> item in PhoneList)
            {
                if (item.Value.Name == name && item.Value.Password == passwork) // item.Value = User 
                {
                    isExits = true;
                    break;
                }                                                                                      
            } 
            if (isExits)
            {
                Console.WriteLine("User checked");
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }

        public static void Display()
        {
            foreach (KeyValuePair<int, User> item in PhoneList)
            {
                Console.WriteLine(item.Value.Info());
            }
        }   
    }
}
