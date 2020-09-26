using System;

namespace Algorithm.Trees
{
    public class BinarySearchTree
    {
        private Node _Root { get; set; }

        public BinarySearchTree(int value)
        {
            _Root = new Node { Value = value };
        }

        public void Insert(int value)
        {
            //       0
            //   5      10
            // 3   6  9    12
            var newNode = new Node { Value = value };

            var currentNode = _Root;
            while (currentNode != null)
            {
                if (currentNode.Value > value)
                {
                    if (currentNode.Left == null)
                    {
                        currentNode.Left = newNode;
                        currentNode = null;
                    }
                    else
                    {
                        currentNode = currentNode.Left;
                    }
                }
                else
                {
                    if (currentNode.Right == null)
                    {
                        currentNode.Right = newNode;
                        currentNode = null;
                    }
                    else
                    {
                        currentNode = currentNode.Right;
                    }
                }
            }
        }

        public bool Lookup(int value)
        {
            if (_Root is null) return false;


            var currentNode = _Root;
            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    return true;
                }

                if (currentNode.Value >= value)
                {
                    currentNode = currentNode.Left;
                }
                else
                {
                    currentNode = currentNode.Right;
                }
            }

            return false;
        }

        //public void Remove(int value)
        //{
        //    //     1
        //    //   2     3
        //    // 4   5  //Right? 
        //    //2   3  7  // Right?

        //    var currentNode = _Root;
        //    while (currentNode != null)
        //    {
        //        if (currentNode.Value == value)
        //        {
        //            RemoveNode(ref currentNode);
        //            break;
        //        }

        //        if (currentNode.Value > value)
        //        {
        //            currentNode = currentNode.Left;
        //        }
        //        else
        //        {
        //            currentNode = currentNode.Right;
        //        }

        //    }
        //}

        //private void RemoveNode(ref Node currentNode)
        //{
        //    var targetNode = currentNode;
        //    while (targetNode != null)
        //    {
        //        if (targetNode.Right != null)
        //        {
        //            targetNode.Value = targetNode.Right.Value;
        //            targetNode = targetNode.Right;
        //            continue;
        //        }

        //        if (currentNode.Left != null)
        //        {
        //            targetNode.Value = targetNode.Left.Value;
        //            targetNode = targetNode.Right;
        //            continue;
        //        }

        //        targetNode = null;
        //    }; 
        //}

        public void Remove(int value)
        {
            if (_Root == null)
            {
                return;
            }

            Node nodeToRemove = _Root;
            Node parentNode = null;
            while (nodeToRemove.Value != value)
            { //Searching for the node to remove and it's parent
                parentNode = nodeToRemove;
                if (value < nodeToRemove.Value)
                {
                    nodeToRemove = nodeToRemove.Left;
                }
                else if (value > nodeToRemove.Value)
                {
                    nodeToRemove = nodeToRemove.Right;
                }
            }

            Node replacementNode = null;
            if (nodeToRemove.Right != null)
            { //We have a right node
                replacementNode = nodeToRemove.Right;
                if (replacementNode.Left == null)
                { //We don't have a left node
                    replacementNode.Left = nodeToRemove.Left;
                }
                else
                { //We have a have a left node, lets find the leftmost
                    Node replacementParentNode = nodeToRemove;
                    while (replacementNode.Left != null)
                    {
                        replacementParentNode = replacementNode;
                        replacementNode = replacementNode.Left;
                    }
                    replacementParentNode.Left = null;
                    replacementNode.Left = nodeToRemove.Left;
                    replacementNode.Right = nodeToRemove.Right;
                }
            }
            else if (nodeToRemove.Left != null)
            {//We only have a left node
                replacementNode = nodeToRemove.Left;
            }

            if (parentNode == null)
            {
                _Root = replacementNode;
            }
            else if (parentNode.Left == nodeToRemove)
            { //We are a left child
                parentNode.Left = replacementNode;
            }
            else
            { //We are a right child
                parentNode.Right = replacementNode;
            }
        }

        //static void Main(string[] args)
        //{
        //    var myTree = new BinarySearchTree(100);

        //    myTree.Insert(1);
        //    myTree.Insert(100);
        //    myTree.Insert(12);

        //    Console.WriteLine(myTree.Lookup(1));
        //    Console.WriteLine(myTree.Lookup(10));

        //    myTree.Remove(12);
        //}
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }
    }

}
