using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueDemo
{
    public class StackCustom<T>
    {
        LinkedList<T> _items = new LinkedList<T>();
        public void Push(T value)
        {
            _items.AddLast(value);
        }

        public T Pop()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The Stack is Empty");
            }

            T result = _items.Last.Value;

            _items.RemoveLast();

            return result;
        }
        public T Peek()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The Stack is Empty");
            }

            return _items.Last.Value;
        }

        public int Count 
        {
            get 
            { 
                return _items.Count; 
            }
        }


    }
}
