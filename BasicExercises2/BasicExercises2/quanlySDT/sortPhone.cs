using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using BasicExercises2.baitap4.Model;



namespace BasicExercises2.baitap4
{
    public class sortPhone : IComparer
    {
        int IComparer.Compare(object a, object b)
        {
            PhoneItem a1 = a as PhoneItem;
            PhoneItem b1 = b as PhoneItem;
            return (string.Compare(a1.Name, b1.Name));
        }
    }
}
