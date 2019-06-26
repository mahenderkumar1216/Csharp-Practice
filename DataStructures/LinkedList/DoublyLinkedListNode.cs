using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class DoublyLinkedListNode<T>
    {


        /// <summary>
        /// Construts a new Node with specified value
        /// </summary>
        /// <param name="value"></param>
        public DoublyLinkedListNode(T value)
        {
            Value = value;
        }

        /// <summary>
        /// Node Value
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Next node of linked list. Null if Last Node
        /// </summary>
        public DoublyLinkedListNode<T> Next { get; set; }

        /// <summary>
        /// Previous Node of the linked list. Null if first node 
        /// </summary>
        public DoublyLinkedListNode<T> Previous { get; set; }

    }
}
