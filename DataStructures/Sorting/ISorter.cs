using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sorting
{
    interface ISorter<T>:IPerformanceTracker where T:IComparable<T>
    {
        void Sort(T[] items);
    }
}
