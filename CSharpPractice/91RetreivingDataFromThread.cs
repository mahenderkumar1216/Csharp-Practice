using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public delegate void SumOfNumbersCallBack(int n);
     public class _91RetreivingDataFromThread
    {
        int _Target;
        SumOfNumbersCallBack _callBackMethod;

        public _91RetreivingDataFromThread(int target, SumOfNumbersCallBack callBackMethod)
        {
            this._Target = target;
            this._callBackMethod = callBackMethod;
        }

        public  void PrintSumOfNumbers()
        {
            int sum = 0;

            for (int i = 0; i <= _Target; i++)
            {
                sum = sum + 1;
            }
            if (_callBackMethod != null)
                _callBackMethod(sum);
        }

        public static void PrintSum(int sum)
        {
            Console.WriteLine("The Sum is " + sum);
        }
    }
}
