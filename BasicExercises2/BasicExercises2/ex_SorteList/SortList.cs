using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.ex_SorteList
{
    public class SortList
    {
        public static void Main()
        {
            SortedList<string, string> EmployeeList = new SortedList<string, string>();
            // SortedList<string, List<string>> EmployeeList = new SortedList<string, List<string>>();  khai báo có nhiu sở thích = list or array.
            // EmployeeList.Add("khoa", new List<string>() { "co tuong", "co nguoi" });


            // cũng có thể khai báo theo kiểu Dictionary như SortedList đều SortedList nó sắp xếp theo a,b,c còn Dictionary thì hiện ra như m nhập và ko có RemoveAt().
            // Dictionary<string, string> EmployeeList = new Dictionary<string, string>();


            // Add item
            EmployeeList.Add("khoa", "co tuong");
            EmployeeList.Add("loc", "co vua");
            EmployeeList.Add("bao", "karaoke");
            // EmployeeList.Add("bao", "swiming");  lỗi vì sortedList ko cho trùng key.

            // show all by value
            Console.WriteLine("Show all value :");
            foreach(var item in EmployeeList.Values)
            {
                Console.WriteLine(item);
            }

            // show all by keys
            Console.WriteLine("\nshow all key :");          
            foreach(var key in EmployeeList.Keys)
            {
                Console.WriteLine(key);
            }

            // show all value by key 
            Console.WriteLine("\nshow all value : ");
            foreach (var key in EmployeeList.Keys)
            {
                Console.WriteLine("key: {0}, value: {1}", key, EmployeeList[key]);
            }

            // Remove item by key
            EmployeeList.Remove("khoa");

            // Remove item by key and return value
            string locValue;
            EmployeeList.Remove("loc", out locValue);
            Console.WriteLine(locValue);

            // Remove item by index
            EmployeeList.RemoveAt(EmployeeList.Count - 1);  // vì 2 thằng trên đã bị xóa rồi nên Count -1 là xóa lun thằng cuối nên ko hiện ra gì cả.

            //Show all value by using enumnator cũng như show all value by key nhưng ko cần dùng vòng foreach.
            var enumerator = EmployeeList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine("key: {0} value: {1}", enumerator.Current.Key, enumerator.Current.Value);
            }

        }
    }
}
