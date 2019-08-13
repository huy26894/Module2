using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class bt56
    {
        static bool checkPalindrome(string str)
        {
            char[] c = str.ToCharArray();
            Array.Reverse(c);
            return new string(c).Equals(str);
        }
        static void Main()
        {
            Console.WriteLine(checkPalindrome("aaa"));
            Console.WriteLine(checkPalindrome("abc"));
            Console.WriteLine(checkPalindrome("madam"));
            Console.WriteLine(checkPalindrome("1234"));
        }
    }
}
