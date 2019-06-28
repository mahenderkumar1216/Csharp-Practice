using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue
{
    class Queue<T> : IEnumerable
    {

        System.Collections.Generic.LinkedList<T> _items = new System.Collections.Generic.LinkedList<T>();

        public void Enqueue(T item)
        {
            _items.AddLast(item);
        }

        public T Dequeue()
        {
            if(_items.Count==0)
            {
                throw new InvalidOperationException("The Queue is Empy");
            }

            T value = _items.First.Value;
            _items.RemoveFirst();
            return value;
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


        public T Peek()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The Queue is Empy");
            }

            return _items.First.Value;
        }
        public IEnumerator GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}
