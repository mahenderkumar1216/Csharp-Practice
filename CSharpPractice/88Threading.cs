using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class _88Threading
    {
        public _88Threading(int Max)
        {
            _MaxNumber = Max;
        }

        static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(PrintNumbers));
            t1.Start();

            //Part 89

            Console.WriteLine("Please enter  the MAx number to display");
            object target = Console.ReadLine();

            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(PrintNumbers);
            Thread t2 = new Thread(parameterizedThreadStart);
            t2.Start(target);

            //Part90 Passing Data to thread Type Safe Manner 
            Console.WriteLine("Part90");
            Console.WriteLine("Please enter  the MAx number to display");
            int target2 = Convert.ToInt32(Console.ReadLine());
            _88Threading xample = new _88Threading(target2);
            Thread t3 = new Thread(new ThreadStart(PrintNumber));
            t3.Start();

        }

        static void PrintNumbers()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void PrintNumbers(object obj)
        {
            int number = 0;
            if (int.TryParse(obj.ToString(), out number))
            {
                for (int i = 0; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }

        }

        private static int _MaxNumber;

        static void PrintNumber()
        {

            int number;
            if (int.TryParse(_MaxNumber.ToString(), out number))
            {
                for (int i = 0; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
