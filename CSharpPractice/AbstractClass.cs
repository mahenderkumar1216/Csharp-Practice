using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    abstract class AbstractClassExample
    {
        public abstract void AbstractMethod();
    }
    class AbstractClass:AbstractClassExample
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Abstract method Implemented");
        }
    }
}
