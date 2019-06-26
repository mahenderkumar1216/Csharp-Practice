using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class _92ThreadAliveJoin
    {

        public static void Main()
        {
            Console.WriteLine("Main Started");
            Thread T1 = new Thread(_92ThreadAliveJoin.ThreadFunction1);
            T1.Start();

            Thread T2 = new Thread(_92ThreadAliveJoin.ThreadFunction2);
            T2.Start();

            T1.Join();
            Console.WriteLine("Thread1Function Completed");
            T2.Join();
            Console.WriteLine("Thread2Function Completed");
            Console.WriteLine("Main Method Completed");
        }
        public static void ThreadFunction1()
        {
            Console.WriteLine("Thread Function1");
        }

        public static void ThreadFunction2()
        {
            Console.WriteLine("Thread Function2");
        }
    }


}
