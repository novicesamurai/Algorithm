using System;
using System.Collections.Generic;

namespace Algorithm.StackAndQueues
{
    public class Queues
    {
        // First in First out
        // As Queue is First in First out. Array can not be used.
        // Array needs to shit all the index. O(n) operation
        // where are stack O(1) operation

        private Node _First;
        private Node _Last;
        private int _Length = 0;

        public string Peek()
        {
            if (_Length == 0) return null;

            return _First.Value;
        }

        public void Enqueue(string value)
        {
            var nextNode = new Node { Value = value };

            if(_Length == 0)
            {
                _First = nextNode;
                _Last = _First; // 
            }
            else
            {
                _Last.Next = nextNode;
                _Last = nextNode;

                // 1 --> 2 
            }
            _Length++;
        }

        public void Dequeue()
        {
            if (_Length == 0) return;

            _First = _First.Next;
            _Length--;
        }

        public void Print()
        {
            // if not empty
            Console.WriteLine(_First.Value);
            var curentNode = _First.Next;
            while (curentNode != null)
            {
                Console.WriteLine(curentNode.Value);
                curentNode = curentNode.Next;
            }
        }

        //IsEmpty

        //static void Main(string[] args)
        //{
        //    var myQueue = new Queues();

        //    myQueue.Enqueue("google");
        //    Console.WriteLine(myQueue.Peek());
        //    myQueue.Enqueue("Udemy");
        //    myQueue.Enqueue("facebook");
        //    //myStack.Push("amazon");
        //    myQueue.Dequeue();
        //    myQueue.Print();
        //}
    }
}
