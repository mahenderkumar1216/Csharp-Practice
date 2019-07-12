using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sorting
{
    class BubbleSort<T> : Tracker<T>, ISorter<T> where T : IComparable<T>
    {
        T[] item;
        public void Sort(T[] items)
        {
            item = items;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < items.Length; i++)
                {
                    if (Comapare(items[i - 1], items[i]) > 0)
                    {
                        Swap(items, i - 1, i);
                        swapped = true;
                    }
                }
            }
            while (swapped != false);
        }

        public void PrintSorted()
        {
            foreach (var i in item)
            {
                Console.Write(i + "\t");

            }
        }
    }
}
