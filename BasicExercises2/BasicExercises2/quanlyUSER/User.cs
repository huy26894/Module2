using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.quanlyUSER
{
    public class User : IUser
    {
        public List<int?> phoneList = new List<int?>();
        protected int id;
        protected string name;
        protected string password;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }

        public string Info()
        {
            if (phoneList == null || phoneList.Count  == 0)
            {
                return $"ID: {ID}, Name: {Name}, Password: {Password}";
            }
            
            else
            {
                return $"ID: {ID}, Name: {Name}, Password: {Password}, PhoneList: {string.Join(",", phoneList)}";
            }
       
        }
    }
}
