using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sorting
{
    public class SelectionSort<T> : Tracker<T>, ISorter<T> where T : IComparable<T>
    {
        T[] _items;
        public void Sort(T[] items)
        {
            _items = items;
            int sortedRangeEnd = 0;
            while (sortedRangeEnd < items.Length)
            {
                int nextIndex = FindIndexOfSmallestFromIndex(items, sortedRangeEnd);
                Swap(items, sortedRangeEnd, nextIndex);
                sortedRangeEnd++;
            }
        }

        public int FindIndexOfSmallestFromIndex(T[] items, int sortedRangeEnd)
        {
            T currentSmallest = items[sortedRangeEnd];

            int currentSmallestIndex = sortedRangeEnd;

            for (int i = sortedRangeEnd; i < items.Length; i++)
            {
                if (Compare(currentSmallest, items[i]) > 0)
                {
                    currentSmallest = items[i];
                    currentSmallestIndex = i;
                }
            }
            return currentSmallestIndex;
        }

        public void PrintSorted()
        {
            foreach (var i in _items)
            {
                Console.Write(i + "\t");

            }
        }
    }
}
