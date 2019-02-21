using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class _40ExceptionHandling
    {
        static void Main()
        {
            throw new UserAlreadyLoggedInException("User Already Logged in Exception");
        }
    }

    [Serializable]
    public class UserAlreadyLoggedInException:Exception
    {
        public UserAlreadyLoggedInException():base()
        {
        }

        public UserAlreadyLoggedInException(string message):base(message)
        {
        }

        public UserAlreadyLoggedInException(string message,Exception innerException):base(message,innerException)
        {
        }
    }
}
