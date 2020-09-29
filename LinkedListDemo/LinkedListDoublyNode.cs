using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms
{
    public class LinkedListDoublyNode<T>
    {
        public T Value { get; set; }

        public LinkedListDoublyNode(T value)
        {
            Value = value;
        }

        public LinkedListDoublyNode<T> Next { get; internal set; }

        public LinkedListDoublyNode<T> Previous { get; internal set; }
    }
}
