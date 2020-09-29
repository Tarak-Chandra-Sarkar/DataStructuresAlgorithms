using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueDemo
{
    public class QueueCustom<T>
    {
        LinkedList<T> _items = new LinkedList<T>();
        public void Enqueue(T value)
        {
            _items.AddFirst(value);
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T result = _items.Last.Value;
            _items.RemoveLast();

            return result;
        }

        public T Peek()
        {
            return _items.Last.Value;
        }

        public int Count
        {
            get { return _items.Count; }
        }
                
    }
}
