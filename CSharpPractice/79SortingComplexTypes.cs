using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class _79SortingComplexTypes
    {
        static void Main()
        {
            foreach (var v in Customer2.listCustomer)
            {
                Console.WriteLine("ID=" + v.ID + ", Name=" + v.Name + ", Salary=" + v.Salary);
            }
            Console.WriteLine("--------------------------------------------------------------------");
            //Method 1
            Comparison<Customer2> customerComparer = new Comparison<Customer2>(ComapreCustomer);
            Customer2.listCustomer.Sort(customerComparer);
            foreach(var v in Customer2.listCustomer)
            {
                Console.WriteLine("ID=" + v.ID + ", Name=" + v.Name + ", Salary=" + v.Salary);
            }
            Console.WriteLine("--------------------------------------------------------------------");

            //Method2
            Customer2.listCustomer.Sort((delegate (Customer2 x, Customer2 y) { return x.Name.CompareTo(y.Name); }));

            foreach (var v in Customer2.listCustomer)
            {
                Console.WriteLine("ID=" + v.ID + ", Name=" + v.Name + ", Salary=" + v.Salary);
            }
            Console.WriteLine("--------------------------------------------------------------------");

            //Method3
            Customer2.listCustomer.Sort((x,y)=>x.Salary.CompareTo(y.Salary));
            foreach (var v in Customer2.listCustomer)
            {
                Console.WriteLine("ID=" + v.ID + ", Name=" + v.Name + ", Salary=" + v.Salary);
            }
            Console.WriteLine("--------------------------------------------------------------------");

        }
        static int ComapreCustomer(Customer2 x, Customer2 y)
        {
            return x.ID.CompareTo(y.ID);
        }
    }
}
