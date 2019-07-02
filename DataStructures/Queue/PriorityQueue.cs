using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue
{
    public class PriorityQueue<T> : IEnumerable<T> where T : IComparable<T>
    {
        LinkedList<T> _items = new LinkedList<T>();
        /// <summary>
        /// Adds an item to the Queue in priority Order
        /// </summary>
        /// <param name="item">Item which should be added to the queue</param>
        public void Enqueue(T item)
        {
            //If list is empty add the item to the end of the list
            if (_items.Count == 0)
            {
                _items.AddLast(item);
            }
            else
            {
                //Find the proper Insert Point
                var current = _items.First;
                //while we are not at the end of list and the current value
                //is larger than the value being inserted
                while (current != null && current.Value.CompareTo(item) > 0)
                {
                    current = current.Next;
                }

                if (current == null)
                {
                    _items.AddLast(item);
                }
                else
                {
                    _items.AddBefore(current, item);
                }
            }
        }

        public T Dequeu()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The Queu is Empty");
            }

            T value = _items.First.Value;
            _items.RemoveFirst();
            return value;
        }

        public T Peek()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The Queu is Empty");
            }

            return _items.First.Value;
        }

        public int Count
        {
            get
            {
                return _items.Count;
            }
        }

        public void Clear()
        {
            _items.Clear();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}
