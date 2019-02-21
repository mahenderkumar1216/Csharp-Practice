using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class _56Generics
    {
        public static void Main()
        {
            bool isEqual = Calculator.AreEqual<string>("a", "a");
            if (isEqual)                      
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");
            bool isEqual1 = Calculator2<string>.AreEqual("a", "a");
            if (isEqual)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");
        }
    }

    class Calculator
    {
        public static bool AreEqual<T>(T A, T B)
        {
            return A.Equals(B);
        }
    }

    class Calculator2<T>
    {
        public static bool AreEqual(T A, T B)
        {
            return A.Equals(B);
        }
    }
}
