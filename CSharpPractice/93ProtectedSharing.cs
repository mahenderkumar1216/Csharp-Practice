using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpPractice
{

    //from perforamnce point of view Interlock is faster than lock 
    class _93ProtectedSharing
    {
        static int total = 0;

        static void Main()
        {
            Stopwatch watch = Stopwatch.StartNew();
            AddOneMillion();
            AddOneMillion();
            AddOneMillion();
            Console.WriteLine("total: " + total);

            Thread t1 = new Thread(_93ProtectedSharing.AddOneMillion);
            Thread t2 = new Thread(_93ProtectedSharing.AddOneMillion);
            Thread t3 = new Thread(_93ProtectedSharing.AddOneMillion);

            t1.Start();t2.Start();t3.Start();
            t1.Join();t2.Join();t3.Join();
            Console.WriteLine("total" + total);

            watch.Stop();
            Console.WriteLine(watch.ElapsedTicks);
        }
        public static void AddOneMillion()
        {
            object _lock = new object();
            for (int i = 0; i < 1000000; i++)
            {
                Interlocked.Increment(ref total);
            }
            //or

            //lock(_lock)
            //{
            //    for (int i = 0; i < 1000000; i++)
            //    {
            //        total++;
            //    }
            //}


            //Part94
            //Both Lock and Monitor.Lock() are same lock is the short hand form of Monitor.Lock()
            bool lockTaken = false;
            Monitor.Enter(_lock, ref lockTaken);
            try
            {
                total++;
            }

            finally
            {
                if (lockTaken)
                    Monitor.Exit(_lock);
            }

        }
    }
}
