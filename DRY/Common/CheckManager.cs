using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DRY.Interface;

namespace DRY.Common
{
    public  class CheckManager
    {

        public static IEmployee GetEmployee(int isManager)
        {
            switch (isManager)
            {
                case var value when isManager>0:
                    return new Manager() { IsManager=true};
                default:
                    return new Employee();
            }
        }
    }
}
