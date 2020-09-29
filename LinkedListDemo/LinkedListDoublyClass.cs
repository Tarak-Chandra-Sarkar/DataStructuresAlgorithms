using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms
{
    public class LinkedListDoublyClass<T> : System.Collections.Generic.ICollection<T>
    {
        LinkedListDoublyNode<T> _head;
        LinkedListDoublyNode<T> _tail;
        public int Count
        {
            get;
            internal set;
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void AddFirst(T item)
        {
            LinkedListDoublyNode<T> node = new LinkedListDoublyNode<T>(item);

            // Save off the head node so we don't lose it.
            LinkedListDoublyNode<T> temp = _head;

            // Point head to the new node.
            _head = node;

            // Insert the rest of the list behind head.
            _head.Next = temp;

            if (Count == 0)
            {
                // If the list was empty then head and tail should 
                // both point to the new node.
                _tail = _head;
            }
            else
            {
                // Before: head -------> 5 <-> 7 -> null 
                // After: head -> 3 <-> 5 <-> 7 -> null
                temp.Previous = _head;
            }

            Count++;
        }

        public void AddLast(T item)
        {
            LinkedListDoublyNode<T> node = new LinkedListDoublyNode<T>(item);

            if (Count == 0)
            {
                _head = node;
            }
            else
            {
                _tail.Next = node;

                // Before: Head -> 3 <-> 5 -> null 
                // After: Head -> 3 <-> 5 <-> 7 -> null 
                // 7.Previous = 5
                node.Previous = _tail;
            }

            _tail = node;
            Count++;
        }

        public void Add(T item)
        {
            AddLast(item);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListDoublyNode<T> current = _head;
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

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                _head = _head.Next;

                Count--;
                if (Count == 0)
                {
                    _tail = null;
                }
                else
                {
                    _head.Previous = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    _head = null;
                    _tail = null;
                }
                else
                {
                    _tail.Previous.Next = null;
                    _tail = _tail.Previous;
                }

                Count--;                
            }
        }
        public bool Remove(T item)
        {
            LinkedListDoublyNode<T> previous = null;
            LinkedListDoublyNode<T> current = _head;

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
                        // Case 3b
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            _tail = previous;
                        }
                        else
                        {
                            // Before: Head -> 3 <-> 5 <-> 7 -> null 
                            // After: Head -> 3 <-------> 7 -> null 
                            // previous = 3 
                            // current = 5 
                            // current.Next = 7 
                            // So... 7.Previous = 3
                            current.Next.Previous = previous;
                        }

                        Count--;
                    }
                    else
                    {
                        // Case 2 or 3a
                        RemoveLast();

                    }
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        public LinkedListDoublyNode<T> Head 
        {
            get { return _head; }
        }

        public LinkedListDoublyNode<T> Tail
        {
            get { return _tail; }
        }


    }
}
