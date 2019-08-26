using System;
using System.Collections.Generic;
using System.Text;
using BasicExercises2.baitap4.Model;

namespace BasicExercises2.baitap4
{
    public class PhoneTest
    {
        public static PhoneBook phoneBook = new PhoneBook();
        public static void Main()
        {
            DrawMenu();
        }
        public static void DrawMenu()            // tạo hàm vẽ list menu.
        {
            int option = 0;
            do
            {
                 Console.WriteLine("PHONEBOOK MANAGEMENT SYSTEM");
                 Console.WriteLine("1. Insert phone");
                 Console.WriteLine("2. Remove phone");
                 Console.WriteLine("3. Update phone");
                 Console.WriteLine("4. Search phone");
                 Console.WriteLine("5. Sort");
                 Console.WriteLine("6. Display");
                 Console.WriteLine("7. Exit");
                 Console.WriteLine("Please select an option from 1 to 6");
                 Console.Write("Option: ");
                 if (int.TryParse(Console.ReadLine(), out var number))
                 {
                        option = number;
                 }
            }
            while (option > 7 || option <= 0);
            Process(option);
        }
        public static void Process(int selected)
        {
            Console.Clear();
            switch (selected)
            {

                case 1:
                {
                    Console.WriteLine("Insert phone ....");
                    CreatePhone();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Remove phone ....");
                    Console.Write("Input Name: ");
                    var name = Console.ReadLine();
                    phoneBook.removePhone(name);
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Update phone....");
                    Console.Write("Input new name: ");
                    var name = Console.ReadLine();
                    Console.Write("Input new number phone: ");
                    var number = Console.ReadLine();
                    phoneBook.updatePhone(name,number);
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Search phone ....");
                    Console.Write("Input Name: ");
                    var name = Console.ReadLine();
                    phoneBook.searchPhone(name);
                    break;
                }
                case 5:
                {
                     Console.WriteLine("Sort ....");
                     phoneBook.sort();
                     Display();
                     break;
                }
                case 6:
                {
                     Console.WriteLine("PHONE BOOK LIST");
                     Display();
                     break;
                }
                case 7:
                default:
                {
                     Environment.Exit(Environment.ExitCode);
                     break;
                }
            }
            DrawMenu();
        }

        public static void CreatePhone()
        {          
                Console.Write("Input name: ");
                var name = Console.ReadLine();

                Console.Write("Input phone number: ");
                var phone = Console.ReadLine();

                phoneBook.insertPhone(name, phone); 
        }
         
        public static void Display()
        {
            Console.WriteLine("Name:\t\t\tPhonenumber:");
            if (phoneBook.PhoneList != null && phoneBook.PhoneList.Count > 0)
            {
                foreach (PhoneItem phoneItem in phoneBook.PhoneList)
                {
                    Console.WriteLine("{0}\t\t\t{1}", phoneItem.Name, phoneItem.PhoneNumber);
                }
            }
        }
    }
}
