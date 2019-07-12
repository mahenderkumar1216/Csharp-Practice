using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructures
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            // Application.Run(new Stack.Form1());

            // Application.Run(new Queue.PriorityQueueForm());

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
            // Stack.PostfixCalculator.Main(new string[] {"5","6","7","*","+","1","-" });

            //int a = 5;
            //int b = 6;
            //Console.WriteLine(a.CompareTo(6).ToString());
            //Console.WriteLine(a.CompareTo(4).ToString());
            //Console.WriteLine(a.CompareTo(5).ToString());

            //Application.Run(new HashTable.HashTableForm());

            Sorting.BubbleSort<int> b = new Sorting.BubbleSort<int>();
            b.Sort(new int[] { 1, 3, 4, 7, 2, 9, 5, 6 });
            b.PrintSorted();
            Console.WriteLine();
            Console.WriteLine("Number of Comparisions:" + b.Comparisons);
            Console.WriteLine("Number of Swaps: " + b.Swaps);
            Console.WriteLine();

            Sorting.InsertionSort<int> insertionSort = new Sorting.InsertionSort<int>();
            insertionSort.Sort(new int[] { 3, 2, 1 });
            insertionSort.PrintSorted();
            Console.WriteLine();
            Console.WriteLine("Number of Comparisions:" + insertionSort.Comparisons);
            Console.WriteLine("Number of Swaps: " + insertionSort.Swaps);
        }
    }
}
