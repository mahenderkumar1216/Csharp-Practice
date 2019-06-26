using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class _100FuncDelegate
    {
        public static void Main()
        {
            Func<int, int, string> fundelegate = (x, y) => (x + y).ToString();

            Console.WriteLine(fundelegate(1, 2));
        }

    }
}
