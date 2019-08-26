using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using BasicExercises2.baitap4.Model;

namespace BasicExercises2.baitap4
{
    public class PhoneBook : Phone
    {
        public ArrayList PhoneList = new ArrayList();
        /*private string phone;          // khai báo biến ,biến này đc dùng để set vào kiểu dữ liệu tạo ra (NewItem)
        private string name;
*/
        /*public string Phone { get => phone; set => phone = value; }
        public string Name { get => name; set => name = value; }*/

        public override void insertPhone(string name, string phone)
        {
            if (PhoneList != null && UserIsExited(name))
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.Name == name)
                    {
                        if (phoneItem.PhoneNumber != phone)
                        {
                            phoneItem.PhoneNumber += ":" + phone;
                        }
                    }
                }
            }
            else
            {
                // cách 1:
                var phoneItem = new PhoneItem();
                phoneItem.Name = name;    // đây là setter khai báo kiểu này là khỏi cần khai báo biến (private string phone và get set cho nó).
                phoneItem.PhoneNumber = phone;
                PhoneList.Add(phoneItem);
            }
                         
            /*
            // cách 2:
            var pI = new PhoneItem()
            {
                Name = name,
                PhoneNumber = phone
            };
            PhoneList.Add(pI);

            // cách 3:
            PhoneList.Add(new PhoneItem()
            {
                Name = name,
                PhoneNumber = phone
            });       */

        }

        public override void removePhone(string name)
        {
            if (PhoneList != null)
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.Name == name)
                    {
                        PhoneList.Remove(phoneItem);
                        break;
                    }
                }
            }
        }    
        public override void searchPhone(string name)
        {
            if (PhoneList != null)
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.Name == name)
                    {
                        Console.WriteLine("Phonenumber's {0} is {1}", name, phoneItem.PhoneNumber);
                        break;
                    }
                }
            }
        }

        public override void sort()
        {
            PhoneList.Sort(new sortPhone());
        }

        public override void updatePhone(string name, string newphone)
        {
            if (PhoneList != null)
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.Name == name)
                    {
                        phoneItem.PhoneNumber = newphone;
                    }
                }
            }
        }

        private bool UserIsExited(string userName)
        {
            if(PhoneList != null)
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if(phoneItem.Name == userName)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

      
    }
}
