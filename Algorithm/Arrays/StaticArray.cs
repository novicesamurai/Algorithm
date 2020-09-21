using System;
using System.Collections.Generic;

namespace Algorithm.Arrays
{
    // Array memory is static and continuous. List memory is dynamic and random
    public class StaticArray
    {
        private object[] _currentList = new object[1];
        private int _length = 0;


        public void Add(string item)
        {
            if(_currentList.Length == _length)
            {
                var doublyList = new object[_length * 2];

                var counter = 0;
                foreach(var i in _currentList)
                {
                    doublyList[counter] = i;
                    counter++;
                }

                _currentList = doublyList;
            }

            _currentList[_length] = item;
            _length++;
        }

        public string IndexOf(int index)
        {
            if (index < 0 || _currentList.Length <= index)
                return null;

            return _currentList[index].ToString();
        }


        public void Remove()
        {
            if (_currentList.Length == 0 || _length == 0) return;

            _currentList[_currentList.Length - 1] = null;
            _length--;

            return;
        }

        public void RemoveAt(int index)
        {
            if (_currentList.Length == 0 || _length == 0) return;

            _currentList[index] = null;

            for(var i = index; i < _length -1; i++)
            {
                // shift item to the left
                _currentList[i] = _currentList[i+1];
            }

            _currentList[_length -1] = null;
            _length--;

            return;
        }


        //static void Main(string[] args)
        //{
        //    //Array
        //    var myArray = new StaticArray();
        //    myArray.Add("item1");
        //    myArray.Add("item2");
        //    myArray.Add("item3");

        //    //myArray.RemoveAt(1);

        //    Console.WriteLine("myIndex1:" + myArray.IndexOf(0));
        //    Console.WriteLine("myIndex2:" + myArray.IndexOf(1));
        //    Console.WriteLine("myIndex3:" + myArray.IndexOf(2));

        //    myArray.Remove();
        //    Console.WriteLine(myArray._length);
        //    Console.WriteLine(myArray.IndexOf(0));
        //    myArray.Remove();
        //    Console.WriteLine(myArray._length);
        //    Console.WriteLine(myArray.IndexOf(0));
        //    myArray.Remove();
        //    Console.WriteLine(myArray._length);
        //    Console.WriteLine(myArray.IndexOf(0));
        //    myArray.Remove();
        //    Console.WriteLine(myArray._length);
        //}
    }
}
