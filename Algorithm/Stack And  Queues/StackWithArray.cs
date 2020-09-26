using System;
using System.Collections.Generic;

namespace Algorithm.StackAndQueues
{
    public class StackWithArray
    {
        // Last in First out

        public object[] _Array; 
        private int _length = 0;
        private int _arraySize;


        public StackWithArray(int size)
        {
            _arraySize = size;
            _Array = new object[_arraySize];
        }

        public string Peek()
        {
            if (_length == 0) return null;

            return (string)_Array[_length - 1];
        }

        public void Push(string value)
        {
            // if static Array
            if(_arraySize == _length)
            {
                var temp = _Array;

                _arraySize *= 2;

                _Array = new object[_arraySize];

                for(var i = 0; i < _length; i++)
                {
                    _Array[i] = temp[i];
                }
            }

            _Array[_length] = value;

            _length++;

            return;
        }

        public void Pop()
        {
            if( _length != 0)
            {
               _Array[_length - 1] = null;
            }
            _length--;
        }

        public void Print()
        {
            for(var i = 0; i < _length; i++)
            {
                Console.WriteLine(_Array[i]);
            }
        }

        //IsEmpty

        //static void Main(string[] args)
        //{
        //    var myStack = new StackWithArray(1);

        //    myStack.Push("google");
        //    Console.WriteLine(myStack.Peek()); 
        //    myStack.Push("Udemy");
        //    myStack.Push("facebook");
        //    //myStack.Push("amazon");
        //    myStack.Pop();
        //    myStack.Print();
        //}
    }
}
