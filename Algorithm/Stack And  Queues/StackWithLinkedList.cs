using System;
using System.Collections.Generic;

namespace Algorithm.StackAndQueues
{
    public class StackWithLinkedList
    {
        // Last in First out 
       
        public Node Top;  // LikedList
        public Node Bottom;
        private int _length = 0;

        public Node Peek()
        {
            if (_length == 0) return null;

            return Top;
        }

        public void Push(string value)
        {
            var next = new Node { Value = value };

           if(_length == 0)
           {
                Bottom = next; //Bottom.Next = null. this is the end.
                Top = next;
            }
           else
           {
                var pointer = Top;
                Top = next;   // Top replaced by new Node
                Top.Next = pointer;  // *(Bottom )1 <-- 2 <-- 3 (Top) backwrods LinkedList
           }
            _length++;
        }

        public void Pop()
        {
            if( _length != 0)
            {
                //var pointer = Top;  //if do this memory holds up the var which is not good
                Top = Top.Next;
                _length--;
            }
        }

        public void Print()
        {
            Console.WriteLine(Top.Value + "-->");
            var currentNode = Top.Next;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value + "-->");
                currentNode = currentNode.Next;
            }
        }

        //IsEmpty

        //static void Main(string[] args)
        //{
        //    var myStack = new StackWithLinkedList();

        //    myStack.Push("google");
        //    myStack.Push("Udemy");
        //    myStack.Push("facebook");
        //    myStack.Push("amazon");
        //    myStack.Pop();
        //    myStack.Print();
        //}
    }

    public class Node {
        public string Value { get; set; }
        public Node Next { get; set; }
    }
}
