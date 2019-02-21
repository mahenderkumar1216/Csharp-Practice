using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class Employee
    {
        public string firstName;
        public string lastName;

        public void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class PartTimeEmployee:Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName+ " Contractor" );
        }
    }

    public class FullTimeEmployee:Employee
    {

    }

     class MethodHiding
    {
        static void Main()
        {
            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.firstName = "PartTime";
            PTE.lastName = "Employee";
            PTE.PrintFullName();

            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.firstName = "FullTime";
            FTE.lastName = "Employee";
            FTE.PrintFullName();
        }                
    }
}


