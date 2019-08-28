using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.ex_List
{
    public class List
    {
        public static void Main()
        {
            List<Dictionary<int, string>> C6 = new List<Dictionary<int, string>>();
            var to1 = new Dictionary<int, string>();
            to1.Add(1, "Khoa Nguyen");                    
            to1.Add(2, "Bao Nguyen");
            C6.Add(to1);

            var to2 = new Dictionary<int, string>();
            to2.Add(11, "Huy Nguyen");
            to2.Add(12, "Ha Nguyen");
            C6.Add(to2);

            foreach (var to in C6)
            {
                foreach(var member in to)
                {
                    Console.WriteLine("Id: {0}, Name: {1}", member.Key, member.Value); 
                }                                            
            }

        }
    }
}
