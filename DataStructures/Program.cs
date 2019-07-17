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

            Application.Run(new Sets.SetsForm());

            Sorting.BubbleSort<int> b = new Sorting.BubbleSort<int>();
            b.Sort(new int[] { 1, 3, 4, 7, 2, 9, 5, 6 });
            b.PrintSorted();
            Console.WriteLine();
            Console.WriteLine("Number of Comparisions for Bubble Sort:" + b.Comparisons);
            Console.WriteLine("Number of Swaps Bubble Sort: " + b.Swaps);
            Console.WriteLine();

            Sorting.InsertionSort<int> insertionSort = new Sorting.InsertionSort<int>();
            insertionSort.Sort(new int[] { 1, 3, 4, 7, 2, 9, 5, 6 });
            insertionSort.PrintSorted();
            Console.WriteLine();
            Console.WriteLine("Number of Comparisions Insertion Sort:" + insertionSort.Comparisons);
            Console.WriteLine("Number of Swaps Insertion Sort: " + insertionSort.Swaps);


            Sorting.SelectionSort<int> selectionSort = new Sorting.SelectionSort<int>();
            selectionSort.Sort(new int[] { 1, 3, 4, 7, 2, 9, 5, 6 });
            selectionSort.PrintSorted();
            Console.WriteLine();
            Console.WriteLine("Number of Comparisions Selection Sort:" + selectionSort.Comparisons);
            Console.WriteLine("Number of Swaps Selection Sort: " + selectionSort.Swaps);

            Sorting.MergeSort<int> mergeSort = new Sorting.MergeSort<int>();
            mergeSort.Sort(new int[] { 1, 3, 4, 7, 2, 9, 5, 6 });
            mergeSort.PrintSorted();
            Console.WriteLine();
            Console.WriteLine("Number of Comparisions Merge Sort:" + mergeSort.Comparisons);
            Console.WriteLine("Number of Swaps Merge Sort: " + mergeSort.Swaps);


            Sorting.QuickSort<int> quickSort = new Sorting.QuickSort<int>();
            quickSort.Sort(new int[] { 1, 3, 4, 7, 2, 9, 5, 6 });
            quickSort.PrintSorted();
            Console.WriteLine();
            Console.WriteLine("Number of Comparisions Quick Sort:" + quickSort.Comparisons);
            Console.WriteLine("Number of Swaps Quick Sort: " + quickSort.Swaps);
        }
    }
}
