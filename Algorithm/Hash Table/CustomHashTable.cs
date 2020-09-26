using System;
using System.Collections.Generic;
using Algorithm.HashTable.Class;

namespace Algorithm.HashTable
{

    // Dictonary vs Hash Table C# https://www.geeksforgeeks.org/difference-between-hashtable-and-dictionary-in-c-sharp/
    // [{'key', 'value'},{'key2', 'value2'}.....]

    // if the same key is given, hash table allocates the data into same address.
    // in other words, hash will convert string into the index. 
    // thats why finding the data is first. O(1)
    public class MyHashTable
    {
        private int _length { get; set; }
        private Node[] _memory { get; set; }

        public MyHashTable(int size)
        {
            _length = size;
            _memory = new Node[size];
        }

        public void Set(string key, string val)
        {
            var address = Hash(key);

            _memory[address] = new Node { Key = key, Value = val };

            return;
        }

        public string GetValue(string key)
        {
            var address = Hash(key);

            if(_memory[address] == null)
            {
                return null;
            }

            return _memory[address].Value;
        }

        public List<string> GetKeys()
        {
            var keyList = new List<string>();

            for(var i = 0; i < _length; i++)
            {
                if (_memory[i] != null)
                {
                    keyList.Add(_memory[i].Key);
                }
            }

            return keyList;
        }

        private int Hash(string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                // takes the hash 0 as secret key combined with first char and
                // shaffle with index and modulo by length to get remainder
                hash = (hash + (int)key[i] * i) % this._length;
            }
            return hash;
        }

        //static void Main(string[] args)
        //{
        //    var myHash = new HashTable(50);
        //    myHash.Set("item1", "10000");
        //    myHash.Set("item1", "10000");
        //    myHash.Set("item2", "20000");
        //    myHash.Set("item3", "10000");
        //    myHash.Set("item4", "20000");
        //    myHash.Set("item5", "10000");
        //    myHash.Set("item6", "20000");
        //    myHash.Set("item7", "10000");
        //    myHash.Set("item8", "20000");
        //    myHash.Set("item9", "10000");
        //    myHash.Set("item10", "20000");
        //    Console.WriteLine(myHash._memory);

        //    var item = myHash.GetValue("item10");
        //    Console.WriteLine(item);

        //    var keys = myHash.GetKeys();
        //    Console.WriteLine(keys);
        //}
    }
}