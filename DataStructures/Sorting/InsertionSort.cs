using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sorting
{
    public class InsertionSort<T> : Tracker<T>, ISorter<T> where T : IComparable<T>
    {
        T[] _items;
        public void Sort(T[] items)
        {
            _items = items;
            int sortedRangeEndIndex = 1;

            while (sortedRangeEndIndex < items.Length)
            {
                if (Comapare(items[sortedRangeEndIndex], items[sortedRangeEndIndex - 1]) < 0)
                {
                    int insertIndex = FindInsertionIndex(items, items[sortedRangeEndIndex]);
                    Insert(items, insertIndex, sortedRangeEndIndex);
                }
                sortedRangeEndIndex++;
            }
        }

        private int FindInsertionIndex(T[] items, T valueToInsert)
        {
            for (int index = 0; index < items.Length; index++)
            {
                if (Comapare(items[index], valueToInsert) > 0)
                {
                    return index;
                }
            }
            throw new InvalidOperationException("The Insert Index Was Not Found");
        }

        private void Insert(T[] itemArray, int indexInsertingAt, int indexInsertingFrom)
        {
            T temp = itemArray[indexInsertingAt];

            Assign(itemArray, indexInsertingAt, itemArray[indexInsertingFrom]);

            for (int current = indexInsertingFrom; current > indexInsertingAt; current--)
            {
                Assign(itemArray, current, itemArray[current - 1]);
            }

            // Step 4
            Assign(itemArray, indexInsertingAt + 1, temp);

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
