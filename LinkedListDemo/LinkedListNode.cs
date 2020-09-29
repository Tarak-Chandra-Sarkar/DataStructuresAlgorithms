using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    /// <summary>
    /// Singly LinkedList Node
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedListDemoNode<T>
    {
        public LinkedListDemoNode(T value)
        {
            Value = value;
        }

        public T Value { get; internal set;}

        public LinkedListDemoNode<T> Next { get; internal set; }
    }
}
