using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{

    public class Employee1
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTimeEmployee1 : Employee1
    {
        public override void PrintName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Part Time");
        }
    }

    public class FullTimeEmployee1 : Employee1
    {
        public override void PrintName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Full Time");
        }
    }
    public class TemporaryEmployee1 : Employee1
    {
        public override void PrintName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Temporary Time");
        }
    }
    class Polymorphism
    {
        public static void Main()
        {
            Employee1[] employees = new Employee1[4];
            employees[0] = new Employee1();
            employees[1] = new PartTimeEmployee1();
            employees[2] = new FullTimeEmployee1();
            employees[3] = new TemporaryEmployee1();

            foreach (Employee1 e in employees)
            {
                e.PrintName();
            }
        }
    }
}
