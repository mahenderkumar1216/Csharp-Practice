using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent Class Constructor Called");
        }

        public ParentClass(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class DerivedClass:ParentClass
    {
        //public DerivedClass()
        //{
        //    Console.WriteLine("Derieved Class Constructor Called");
        //}

        public DerivedClass():base("Derived Class Controlling Parent Class")
        {

        }
    }

    public class Inheritance
    {
        static void Main()
        {
            DerivedClass d = new DerivedClass();
        }        
    }
}
