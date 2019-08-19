using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.ex_interface2
{
    class Cat : Animal, CanEat, CanDrink
    {
        public string HowCanEat()
        {
            return "eat fish";
        }

        public string HowCanDrink()
        {
            return "drink water";
        }
        public override string HowCanMove()
        {
            return "running cat";
        }
    }
}
