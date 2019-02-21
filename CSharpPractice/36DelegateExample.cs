using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class _36DelegateExample
    {
        static void Main()
        {
            List<DelEmployee> employees = new List<DelEmployee>
            {
                new DelEmployee(){Id=1,Name="Bea",Experience=6,Salary=5000},
                new DelEmployee(){Id=1,Name="Rob",Experience=3,Salary=2000},
                new DelEmployee(){Id=1,Name="Mike",Experience=7,Salary=6000},
                new DelEmployee(){Id=1,Name="Sul",Experience=4,Salary=4000}
            };
            IsPromotable isPromotable = new IsPromotable(Promote);
            //DelEmployee.PromoteEmployee(employees,isPromotable);
            DelEmployee.PromoteEmployee(employees, emp => emp.Experience >= 5);
            Console.ReadLine();
        }
        public static bool Promote(DelEmployee emp)
        {
            if (emp.Experience >= 5)
                return true;
            else
                return false; 
        }
    }
    delegate bool IsPromotable(DelEmployee emp1);
    class DelEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<DelEmployee> employeeList,IsPromotable IsEligibleToPromote)
        {
            foreach(DelEmployee emp in employeeList)
            {
                if(IsEligibleToPromote(emp))
                {
                    Console.WriteLine(emp.Name + " Promoted");
                }
            }
        }
    }
}
