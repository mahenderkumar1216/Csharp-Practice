using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    class LinkedListNode<T>
    {

        /// <summary>
        /// Construts a new node with specified Value
        /// </summary>
        /// <param name="value"></param>
        public LinkedListNode(T value)
        {
            Value = value;
        }
        /// <summary>
        /// The Node value
        /// </summary>
        public T Value;

        /// <summary>
        /// Next Node in the List
        /// </summary>
        public LinkedListNode<T> Next { get; set; }
    }
}
