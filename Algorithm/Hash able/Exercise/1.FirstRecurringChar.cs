using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithm.Arrays.Excercise
{
    static class FirstRecurringChar
    {

        public static bool Find(List<int> item)
        {
            if (item.Count == 0) return false;

            var hashTable = new Hashtable();

            for(var i = 0; i < item.Count; i++)
            {
                if (hashTable.ContainsKey(item[i]))
                {
                    return true;
                }
                hashTable[item[i]] = item[i];
            }

            Console.WriteLine(hashTable);

            return false;

        }

        static void Main(string[] args)
        {
            //[1,2,2,4,6,7] -> true
            //[1,2,3,4,2,7] -> true
            //[1,2,7] -> false

            Console.WriteLine(FirstRecurringChar.Find(new List<int> { 1, 2, 2, 4, 6, 7 }));
        }
    }


    //Hash table



}
