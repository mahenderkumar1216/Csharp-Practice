using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class _65Indexers
    {
        static void Main()
        {
            CompanyIndexer c = new CompanyIndexer();
            Console.WriteLine("Enter Employee Id");
            int id = Convert.ToInt32(Console.ReadLine());
            string name = c[id];
            if (name == null || name == string.Empty)
                Console.WriteLine("Employee With ID=" + id + " Not found");
            else
                Console.WriteLine("Employee ID=" + id + " Employee Name=" + name);
            Console.WriteLine("Employee Male Count="+c["Male"]);
            Console.WriteLine("Employee Female Count=" + c["Female"]);
            Console.ReadLine();
        }
    }

    class EmpIndexers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    class CompanyIndexer
    {
        private List<EmpIndexers> listEmployees;
        public CompanyIndexer()
        {
            listEmployees = new List<EmpIndexers>();
            listEmployees.Add(new EmpIndexers() { Id = 1, Name = "Mahender", Gender = "Male" });
            listEmployees.Add(new EmpIndexers() { Id = 2, Name = "Mellisa", Gender = "Female" });
            listEmployees.Add(new EmpIndexers() { Id = 3, Name = "Kumar", Gender = "Male" });
            listEmployees.Add(new EmpIndexers() { Id = 4, Name = "Tom", Gender = "Male" });
            listEmployees.Add(new EmpIndexers() { Id = 5, Name = "Kathy", Gender = "Female" });
            listEmployees.Add(new EmpIndexers() { Id = 6, Name = "Karen", Gender = "Female" });
            listEmployees.Add(new EmpIndexers() { Id = 7, Name = "Alex", Gender = "Male" });
        }

        public string this[int Id]
        {
            get
            {
                var emp = listEmployees.FirstOrDefault(x => x.Id == Id);
                if (emp != null)
                    return emp.Name;
                else
                    return string.Empty;
            }
        }
        public int this[string  Gender]
        {
            get
            {
               return listEmployees.Count(x => x.Gender == Gender);               
            }
        }
    }
}
