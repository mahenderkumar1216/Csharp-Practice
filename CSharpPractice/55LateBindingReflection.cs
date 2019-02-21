using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class _55LateBindingReflection
    {
        private static void Main()
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type customerType = executingAssembly.GetType("CSharpPractice.CustomerRef");
            object customerInstance = Activator.CreateInstance(customerType);
            MethodInfo info = customerType.GetMethod("FullName");
            string[] paramters = new string[2];
            paramters[0] = "Mahender";
            paramters[1] ="kumar";
            string fullName=  (string)info.Invoke(customerInstance, paramters);
            Console.WriteLine(fullName);
        }        
    }

    class CustomerRef
    {
        public string FullName(string firstName, string lastName)
        {
            return firstName + " " + lastName; 
        }
    }
}
