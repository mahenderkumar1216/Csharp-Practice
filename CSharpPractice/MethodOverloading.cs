using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class MethodOverloading
    {
        public static void Main()
        {

        }

        public  static void Add(int a, int b)
        {
            Console.WriteLine("Sum={0}", a + b);
        }

        public static void Add(int a, int b, int c)
        {
            Console.WriteLine("Sum={0}", a + b + c);
        }
    }
}
