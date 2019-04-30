using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class Customer2:IComparable<Customer2>
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public String Gender { get; set; }

        public Decimal Salary { get; set; }
        

       public static List<Customer2> listCustomer = new List<Customer2>()
       {
            new Customer2() { ID = 1, Name = "Kumar",Gender="Male", Salary = 6000M },
            new Customer2() { ID = 2, Name = "Melissa", Gender="Female", Salary =8000M},
            new Customer2() { ID = 3, Name = "bhuvi",Gender="Male", Salary = 35000M },
            new Customer2() { ID = 4, Name = "Tom", Gender="Male", Salary = 2000M },
            new Customer2() { ID = 5, Name = "Fran", Gender="Female", Salary = 3000M },
            new Customer2() { ID = 6, Name = "Rachel", Gender="Female", Salary = 5000M },
            new Customer2() { ID = 7, Name = "Scott", Gender= "Male", Salary = 1000M },
            new Customer2() { ID = 8, Name = "Finn", Gender= "Male", Salary = 2400M },
            new Customer2() { ID = 9, Name = "Chris", Gender="Male", Salary= 3300M }
       };

        public int CompareTo(Customer2 other)
        {
            return this.ID.CompareTo(other.ID);
        }
    }

    public  class SortByName : IComparer<Customer2>
    {
        public int Compare(Customer2 x, Customer2 y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    public class SortBySalary : IComparer<Customer2>
    {
        public int Compare(Customer2 x, Customer2 y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }
}
