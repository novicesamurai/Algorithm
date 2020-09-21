using System;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace Algorithm.Arrays.Excercise
{
    static class ReverseString
    {

        public static string Reverse(string str)
        {
            if (string.IsNullOrEmpty(str)) return null;

            var reversedString = new StringBuilder();
            for(var i = str.Length-1; i >= 0; i-- )
            {
                reversedString.Append(str[i]);
            }

            return reversedString.ToString();

        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(ReverseString.Reverse(null)); // null case
        //    Console.WriteLine(ReverseString.Reverse("abcde")); // positive test
        //    Console.WriteLine(ReverseString.Reverse("@[;@;];@[1")); // special char
        //    Console.WriteLine(ReverseString.Reverse("1 2 3")); // space?
        //    //in memory?
        //    //Ascii / Unicode ?
        //}
    }
}
