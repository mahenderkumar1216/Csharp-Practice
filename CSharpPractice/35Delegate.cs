using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public delegate void CallDelegateFuction(string Message);
    class _35Delegate
    {
        public static void Main()
        {
            CallDelegateFuction delegateexample = new CallDelegateFuction(Hello);
            delegateexample("Hello from Delegate");
        }

        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }
}
