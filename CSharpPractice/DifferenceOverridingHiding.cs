using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{

    public  class BaseClass
    {
        public void PrintHidingMethod()
        {
            Console.WriteLine("Base Class Print method called using PrintHidingMethod");
        }

        public virtual void PrintOverridingMethod()
        {
            Console.WriteLine("Base Class Print method called using PrintOverridingMethod");
        }
    }

    public class DerivedClass1:BaseClass
    {
        public  new void PrintHidingMethod()
        {
            Console.WriteLine("Child Class Print method called using PrintHidingMethod");
        }
    }

    public class DerivedCalss2:BaseClass
    {
        public override void PrintOverridingMethod()
        {
            Console.WriteLine("Child Class Print method called using PrintHidingMethod");
        }

    }

    class DifferenceOverridingHiding
    {
        static void Main()
        {
            BaseClass B1 = new DerivedClass1();
            B1.PrintHidingMethod();

            BaseClass B2 = new DerivedCalss2();
            B2.PrintOverridingMethod();
        }
    }
}
