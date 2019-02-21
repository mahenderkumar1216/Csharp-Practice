using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    interface IA
    {
        void AMethod();
    }

    interface IB
    {
        void BMethod();
    }

    class AB : IA, IB
    {
        public void AMethod()
        {
            Console.WriteLine("A Method");
        }

        public void BMethod()
        {
            Console.WriteLine("B Method");
        }
    }
    class _35MutipleClassInterface
    {
       public static void Main()
        {
            AB ab = new AB();
            ab.AMethod();
            ab.BMethod();
        }
    }
}
