using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue
{
    class QueueArray<T> : IEnumerable<T>
    {

        T[] _items = new T[0];

        // Number of items in the Queue
        int _size = 0;

        //the first item in the Queue. The first to get out when used Dequeue
        int _head = 0;

        //the last item in the Queue. The last item to get out when used Dequeue
        int _tail = -1;

        public void Enqueu(T item)
        {
            if (_items.Length == _size)
            {
                int newLength = (_size == 0) ? 4 : _size * 4;
                T[] newArray = new T[newLength];

                if (_size > 0)
                {
                    int targetIndex = 0;

                    if (_tail < _head)
                    {
                        for (int index = _head; index < _items.Length; index++)
                        {
                            newArray[targetIndex] = _items[index];
                            targetIndex++;
                        }

                        for (int index = _head; index <= _tail; index++)
                        {
                            newArray[targetIndex] = _items[index];
                            targetIndex++;
                        }
                    }
                    else
                    {
                        for (int index = _head; index <= _tail; index++)
                        {
                            newArray[targetIndex] = _items[index];
                            targetIndex++;
                        }
                    }

                    _head = 0;
                    _tail = targetIndex - 1;
                }
                _items = newArray;
            }
            if (_tail == _items.Length - 1)
            {
                _tail = 0;
            }
            else
            {
                _tail++;
            }
            _items[_tail] = item;
            _size++;
        }

        public T Dequeue()
        {
            if(_size==0)
            {
                throw new InvalidOperationException("The Queue is Empty");
            }
            T value = _items[_head];

            if(_head==_items.Length-1)
            {
                _head = 0;
            }
            else
            {
                _head++;
            }
            _size--;
            return value;
        }

        public T Peek()
        {
            if(_size==0)
            {
                throw new InvalidOperationException("The Queue is Empty");
            }
            return _items[_head];
        }

        public int Count
        {
            get
            {
                return _size;
            }
        }

        public void Clear()
        {
            _size = 0;
            _head = 0;
            _tail = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            if(_size>0)
            {
                if(_tail<_head)
                {
                    for(int index=_head;index<_items.Length;index++)
                    {
                        yield return _items[index];
                    }

                    for(int index=0;index<=_tail;index++)
                    {
                        yield return _items[index];
                    }
                }
                else
                {
                    for(int index=_head;index<=_tail;index++)
                    {
                        yield return _items[index];
                    }
                } 
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
