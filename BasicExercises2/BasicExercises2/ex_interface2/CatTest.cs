using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.ex_interface2
{
    class CatTest
    {
        public static void Main()
        {
            var Tamthe = new Cat();
            Console.WriteLine("Tamthe : {0}", Tamthe.HowCanMove());
            Console.WriteLine("Tamthe : {0}", Tamthe.HowCanEat());         
            Console.WriteLine("Tamthe : {0}", Tamthe.HowCanDrink());
        }
    }
}
