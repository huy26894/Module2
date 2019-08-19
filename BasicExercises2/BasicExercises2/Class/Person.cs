using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.Class
{
    class Person
    {
        private int age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int n)
        {
            age = n;
        }
        public int GetAge()
        {
            return age;
        }
           
    }
    class Student : Person
    {
        public void GoToClass()
        {
            Console.WriteLine("I’m going to class.");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} years old",GetAge());
        }
    }
    class Teacher : Person
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }
    class StudentAndTeacherTest
    {
        static void Main()
        {
            Console.WriteLine("*****Person Class*****");
            Person myPerson = new Person();  // cách khai báo khác : var huy = new Person();
            myPerson.Greet();
            Console.WriteLine("*****Student Class*****");
            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();
            Console.WriteLine("*****Teacher Class*****");
            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();
            
        }
    }
}
