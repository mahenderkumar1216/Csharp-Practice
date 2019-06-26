using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class _97PerformanceofMultithreaded
    {
        public static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SumOfEvennumbers();
            SumOfOddNumbers();
            stopwatch.Stop();

            Console.WriteLine("Totsl Milliseconds without thread:" + stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
            stopwatch.Start();
            Thread t1 = new Thread(SumOfEvennumbers);
            Thread t2 = new Thread(SumOfOddNumbers);

            t1.Start();t2.Start();
            stopwatch.Stop();
            t1.Join();t2.Join();
            Console.WriteLine("Totsl Milliseconds with thread:" + stopwatch.ElapsedMilliseconds);
            Console.ReadLine();
        }

        public static void SumOfEvennumbers()
        {
            double sum = 0;

            for(int i=0;i<10000000;i++)
            {
                if(i%2==0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum Of Even Numbers:" + sum);
        }

        public static void SumOfOddNumbers()
        {
            double sum = 0;

            for (int i = 0; i < 10000000; i++)
            {
                if (i % 2 == 1)
                {
                    sum = sum + i;
                }                
            }
            Console.WriteLine("Sum Of odd Numbers:" + sum);
        }
    }
}
