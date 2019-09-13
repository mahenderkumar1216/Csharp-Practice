using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DRY.Interface;

namespace DRY
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public bool IsManager { get; set; }

        public decimal bonus { get; set; }
        public decimal Bonus { get { return bonus; } }

        

        public virtual void SetBonus(decimal freightUsedForBonus)
        {
            bonus = freightUsedForBonus / 1000;
        }
    }

    public class Manager:Employee
    {
        public override void SetBonus(decimal freightUsedForBonus)
        {
            bonus = freightUsedForBonus / 10;
        }
    }
}
