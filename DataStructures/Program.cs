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

            Application.Run(new HashTable.HashTableForm());
        }
    }
}
