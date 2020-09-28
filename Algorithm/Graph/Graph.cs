using System;
using System.Collections.Generic;

namespace Algorithm.Graph
{
    public class MyGrapgh
    {
        private Dictionary<string, Node> _adjacentList;
        private int _numberOfNodes;

        public MyGrapgh()
        {
            _numberOfNodes = 0;
            _adjacentList = new Dictionary<string, Node>();

        }

        public void AddVerTex(Node node)
        {
            if(!_adjacentList.ContainsKey(node.Value))
            {
                _adjacentList.Add(node.Value, node);
                _numberOfNodes++;
            }
        }

        public void AddEdge(Node node1, Node node2)
        {
            //undirected Graph
            if (_adjacentList.ContainsKey(node1.Value)
                && _adjacentList.ContainsKey(node2.Value))
            {
                _adjacentList[node1.Value] = node2;
                _adjacentList[node2.Value] = node1;
            }

        }


        static void Main(string[] args)
        {
            var myLinkedList = new MyGrapgh();

            myLinkedList.AddVerTex(new Node { Value = "1"});
            myLinkedList.AddVerTex(new Node { Value = "2" });
            myLinkedList.AddVerTex(new Node { Value = "3" });
            myLinkedList.AddVerTex(new Node { Value = "4" });
            myLinkedList.AddVerTex(new Node { Value = "5" });
            myLinkedList.AddVerTex(new Node { Value = "6" });

            myLinkedList.AddEdge(new Node { Value = "1" }, new Node { Value = "2"});
            myLinkedList.AddEdge(new Node { Value = "2" }, new Node { Value = "4" });
        }

    }

    public class Node
    {
        public string Value;
        public Node ConnectedValue { get; set; }
    }
}
