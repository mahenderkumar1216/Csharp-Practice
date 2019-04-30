using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Generics
{
    class GenericsIntro
    {
        static void Main()
        {
            // int is the type argument
            GenericList1 list = new GenericList1();

            for (int x = 0; x < 10; x++)
            {
                list.AddHead(x);
            }

            foreach (int i in list)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine("\nDone");
        }
    }

    public class GenericList1
    {
        private class Node
        {
            public Node(int i)
            {
                next = null;
                data = i;
            }

            private Node next;
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
            private int data;
            public int Data
            {
                get { return data; }
                set { data = value; }
            }
        }

        private Node head;

        public GenericList1()
        {
            head = null;
        }

        public void AddHead(int i)
        {
            Node n = new Node(i);
            n.Next = head;
            head = n;
        }
        public IEnumerator<int> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
