using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.ex_class_interface
{
    class AnimalTest
    {
        public static void Main()
        {
            Console.WriteLine("       *******Chicken*******       ");
            var chip = new Chicken();
            Console.WriteLine("chip says: {0}", chip.MakeSound());
            Console.WriteLine("chip eats: {0}", chip.HowToEat());

            Console.WriteLine("\n       *******Tiger*******       ");
            var puma = new Tiger();
            Console.WriteLine("Puma says: {0}", puma.MakeSound());
            
            Console.WriteLine("\n       *******Apple*******       ");
            var china = new Apple();
            Console.WriteLine("China eats: {0}", china.HowToEat());

            Console.WriteLine("\n       *******Orange*******      ");
            var sanh = new Orange();
            Console.WriteLine("Sanh eats: {0}", sanh.HowToEat());
            Console.ReadKey();
        }
    }
}
