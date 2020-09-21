using System;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace Algorithm.Arrays.Excercise
{
    static class MergeSortedList
    {

        public static List<int> Merge(List<int> list1, List<int> list2)
        {
            //O(N)
            var list1Index = 0;
            var list2Index = 0;
            var mergedList = new List<int>();


            while (list1Index < list1.Count && list2Index < list2.Count)
            {
                if (list1[list1Index] >= list2[list2Index])
                {
                    mergedList.Add(list2[list2Index]);
                    list2Index++;
                }
                else
                {
                    mergedList.Add(list1[list1Index]);
                    list1Index++;
                } 
            };

            //pick up the last index item
            while (list1Index < list1.Count)
            {               
                mergedList.Add(list1[list1Index]);
                list1Index++;
            };

            //pick up the last index item
            while (list2Index < list2.Count)
            {
                mergedList.Add(list2[list2Index]);
                list2Index++;             
            };

            return mergedList;
        }

        //static void Main(string[] args)
        //{
        //    var list1 = new List<int> { 1, 2, 3, 7, 7, 9 };
        //    var list2 = new List<int> { 0, 0, 1, 2, 3, 7 };

        //    var mergeList = Merge(list1, list2);
        //    Console.WriteLine(string.Join("\t", mergeList)); 
        //}
    }
}
