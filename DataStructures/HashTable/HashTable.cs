using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashTable
{
    public class HashTable<TKey, TValue>
    {
        const double _fillFactor = 0.75;

        int _maxItemsAtCurrentSize;

        int _count;

        HashTableArray<TKey, TValue> _array;

        public HashTable() : this(1000)
        {
        }

        public HashTable(int initialCapacity)
        {
            if (initialCapacity < 1)
            {
                throw new ArgumentOutOfRangeException("Intial Capacity");
            }

            _array = new HashTableArray<TKey, TValue>(initialCapacity);

            _maxItemsAtCurrentSize = (int)(initialCapacity * _fillFactor) + 1;
        }

        public void Add(TKey key, TValue value)
        {
            if (_count >= _maxItemsAtCurrentSize)
            {
                HashTableArray<TKey, TValue> largerArray = new HashTableArray<TKey, TValue>(_array.Capacity * 2);
                foreach (HashTableNodePair<TKey, TValue> node in _array.Items)
                {
                    largerArray.Add(node.Key, node.Value);
                }

                _array = largerArray;

                _maxItemsAtCurrentSize = (int)(_array.Capacity * _fillFactor) + 1;
            }

            _array.Add(key, value);
            _count++;
        }

        public bool Remove(TKey key)
        {
            bool removed = _array.Remove(key);
            if (removed)
            {
                _count--;
            }
            return removed;
        }

        public TValue this[TKey key]
        {
            get
            {
                TValue value;
                if (!_array.TryGetValue(key, out value))
                {
                    throw new ArgumentException("key");
                }

                return value;
            }
            set
            {
                _array.Update(key, value);
            }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            return _array.TryGetValue(key, out value);
        }

        public bool ContainsKey(TKey key)
        {
            TValue value;
            return _array.TryGetValue(key, out value);
        }

        public bool ContainsValue(TValue value)
        {
            foreach (TValue foundValue in _array.Values)
            {
                if (value.Equals(foundValue))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Returns an enumerator for all of the keys in the hash table
        /// </summary>
        public IEnumerable<TKey> Keys
        {
            get
            {
                foreach (TKey key in _array.Keys)
                {
                    yield return key;
                }
            }
        }

        /// <summary>
        /// Returns an enumerator for all of the values in the hash table
        /// </summary>
        public IEnumerable<TValue> Values
        {
            get
            {
                foreach (TValue value in _array.Values)
                {
                    yield return value;
                }
            }
        }

        /// <summary>
        /// Removes all items from the hash table
        /// </summary>
        public void Clear()
        {
            _array.Clear();
            _count = 0;
        }

        /// <summary>
        /// The number of items currently in the hash table
        /// </summary>
        public int Count
        {
            get
            {
                return _count;
            }
        }
    }
}
