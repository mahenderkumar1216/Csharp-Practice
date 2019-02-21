using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{

    class Customer
    {
        string _firstName;
        string _lastName;

        public Customer() 
            : this("No First Name Provided", "No Last Name Provided")
        {

        }

        public Customer(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public void PrintName()
        {
            Console.WriteLine("Full Name ={0}", this._firstName + " " + this._lastName);
        }

        ~Customer()
        {
            //Clean up code
        }
    }
    class ClassesExample
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("Mahender", "Kumar");
            c.PrintName();
            Customer c1 = new Customer();
            c1.PrintName();
        }
    }
}
