using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    interface ICustomer
    {
        void Print();
    }
    interface I1
    {
        void InterfaceMethod();
    }

    interface I2
    {
        void InterfaceMethod();
    }
    class Customer1 : ICustomer,I1,I2
    {

        //This is called Explicit Implementing the Interface and no modifiers can be used
         void I1.InterfaceMethod()
        {
            Console.WriteLine("Interface 1 Implemented");
        }

         void I2.InterfaceMethod()
        {
            Console.WriteLine("Interface 2 Implemented");
        }

        public void Print()
        {
             
        }

       
    }

    class InterfaceExample
    {
        public static void Main()
        {
            Customer1 c1 = new Customer1();
            c1.Print();
            ICustomer IC1 = new Customer1();
            IC1.Print();

            ((ICustomer)c1).Print();

            I1 i1 = new Customer1();
            I2 i2 = new Customer1();
            i1.InterfaceMethod();i2.InterfaceMethod();

            
        }

    }
}
