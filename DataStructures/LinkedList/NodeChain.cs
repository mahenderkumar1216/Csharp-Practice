using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    class NodeChain
    {
        public static void Main()
        {
            Node first = new Node { value = 1 };

            Node middle = new Node { value = 4 };
            first.Next = middle;

            Node last = new Node { value = 6 };
            middle.Next = last;

            PrintList(first);
        }

        static void PrintList(Node node)
        {
            while(node!=null)
            {
                Console.WriteLine(node.value);
                node = node.Next;
            }
        }  
    }

    class Node
    {
        public int value { get; set; }
        public Node Next { get; set; }
    }
}
