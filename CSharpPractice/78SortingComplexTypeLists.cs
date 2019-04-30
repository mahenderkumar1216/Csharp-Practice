using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class _78SortingComplexTypeLists
    {
       static void Main()
        {
            SortByName sortByName = new SortByName();
            SortBySalary sortBySalary = new SortBySalary();
            Customer2.listCustomer.Sort(sortByName);
            
            foreach(var v in Customer2.listCustomer)
            {
                Console.WriteLine("ID="+v.ID+ ", Name="+v.Name+", Salary="+v.Salary);
            }
            Console.WriteLine("--------------------------------------------------------------------");
            Customer2.listCustomer.Sort(sortBySalary);

            foreach (var v in Customer2.listCustomer)
            {
                Console.WriteLine("ID=" + v.ID + ", Name=" + v.Name + ", Salary=" + v.Salary);
            }

        }
    }
}
