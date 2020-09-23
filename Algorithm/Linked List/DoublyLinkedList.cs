using System;
using Algorithm.LinkedList.Class;

// object -> class

namespace Algorithm.LinkedList
{
    public class DoublyLinkedList
    {
        private Node _head;
        private Node _tail;
        private int _length;

        public DoublyLinkedList(string value)
        {
            _head = new Node { Value = value, Next = null }; 
            _tail = _head;
            _length = 1;
        }

        public void Append(string value)
        {
            // add the item to end
            var next = new Node { Value = value };  // 1 --> 2  --> 3
            next.Parent = _tail;
            _tail.Next = next;
            _tail = next;
            _length++;
        }

        public void Prepend(string value)
        {
            // add the item to head
            //var head = new Node { Value = value, Next = _head };
            //_head = head;

            var newHead = new Node { Value = value, Next = null };
            _head.Parent = newHead;
            newHead.Next = _head;
            _head = newHead;
            _length++;
        }

        public void Insert(int index, string value)
        {
            if (index <= 0) return;

            var newNode = new Node { Value = value, Next = null };

            var leader = TraverseByIndex(index - 1); // 1 --> 2--> 3 

            if (leader == null) return;

            var childNode = leader.Next;

            leader.Next = newNode;
            newNode.Parent = leader;
            newNode.Next = childNode;
            childNode.Parent = newNode;

            return;
        }

        public void Delete(int index)
        {
            if (index <= 0) return;

            var leader = TraverseByIndex(index - 1); // 1 --> 3 

            if (leader == null) return;

            var unwantedNode = leader.Next; // make a reference
            leader.Next = unwantedNode.Next;
            this._length--;
            return;
        }

        private Node TraverseByIndex(int index)
        {
            int counter = 0;
            var currentNode = _head;
            while (index != counter)
            {
                if (currentNode.Next == null)
                {
                    currentNode = null;
                    break;
                }

                currentNode = currentNode.Next;
                counter++;
            }

            return currentNode;
        }

        public void PrintList()
        {
            if (_head == null)
            {
                return;
            }
            Node current = _head;
            while (current != null)
            {
                Console.Write("-->" + current.Value);
                current = current.Next;
            }
            Console.WriteLine();
        }

        //static void Main(string[] args)
        //{
        //    var myLinkedList = new CustomLinkedList("item1");

        //    myLinkedList.Append("item2");
        //    myLinkedList.Append("item3");
        //    myLinkedList.Append("item4");

        //    myLinkedList.Prepend("item01");

        //    myLinkedList.Insert(2, "item2-5");

        //    myLinkedList.Delete(2);

        //    myLinkedList.PrintList();
        //}
    }
}