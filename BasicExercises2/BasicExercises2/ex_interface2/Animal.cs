using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises2.ex_interface2
{
    class Animal : CanMove
    {
        public virtual string HowCanMove()
        {
            return "Move";
        }
    }
}
