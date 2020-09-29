using LinkedListDemo;
using System.Collections;
using System.Collections.Generic;

namespace DataStructuresAlgorithms
{
    public class LinkedListDemoClass<T> : System.Collections.Generic.ICollection<T>
    {
        private LinkedListDemoNode<T> _head;
        private LinkedListDemoNode<T> _tail;
        public int Count
        {
            get;
            private set;
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        /// <summary>
        /// Adding an item to a linked list involves three steps:
        /// 1. Allocate the new LinkedListNode instance.
        /// 2. Find the last node of the existing list.
        /// 3. Point the Next property of the last node to the new node.
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            LinkedListDemoNode<T> node = new LinkedListDemoNode<T>(item);

            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }

            Count++;
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            LinkedListDemoNode<T> current = _head;
            while (current != null)
            {
                if(current.Value.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListDemoNode<T> current = _head;

            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListDemoNode<T> current = _head;

            while (current != null)
            {
                yield return current.Value;

                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }

        /// <summary>
        /// The basic algorithm for node removal is:
        /// 1. Find the node to remove.
        /// 2. Update the Next property of the node that precedes the node being removed to point to the node that follows the node being removed.
        /// 
        /// As always, the devil is in the details. There are a few cases we need to be thinking about when removing a node:
        /// The list might be empty, or the value we are trying to remove might not be in the list. In this case the list would remain unchanged.
        /// The node being removed might be the only node in the list. In this case we simply set the _head and _tail fields to null.
        /// The node to remove might be the first node.In this case there is no preceding node, so instead we need to update the _head field to point to the new head node.
        /// The node might be in the middle of the list.This is the case demonstrated in Figures 3 and 4.
        /// The node might be the last node in the list. In this case we update the _tail field to reference the penultimate node in the list and set its Next property to null.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(T item)
        {
            LinkedListDemoNode<T> previous = null;
            LinkedListDemoNode<T> current = _head;

            // 1: Empty list: Do nothing. 
            // 2: Single node: Previous is null. 
            // 3: Many nodes: 
            //    a: Node to remove is the first node. 
            //    b: Node to remove is the middle or last.

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    // It's a node in the middle or end.
                    if (previous != null)
                    {
                        // Case 3b. 
                        // Before: Head -> 3 -> 5 -> null
                        // After:  Head -> 3 -> null
                        previous.Next = current.Next;

                        // It was the end, so update _tail.
                        if (current.Next == null)
                        {
                            _tail = previous;
                        }
                    }
                    else
                    {
                        // Case 2 or 3a. 
                        // Before: Head -> 3 -> 5 
                        // After: Head ------> 5

                        // Head -> 3 -> null 
                        // Head ------> null
                        _head = _head.Next;

                        // Is the list now empty?
                        if (_head == null)
                        {
                            _tail = null;
                        }
                    }

                    Count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }        

        public void PrintList()
        {
            LinkedListDemoNode<T> current = _head;
            while (current != null)
            {
                System.Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}