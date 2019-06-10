using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.SingletonPattern
{
    public class ExceptionHandler
    {

        private StreamWriter _StreamWriter;
        private static ExceptionHandler _Instance;

        private static readonly object _Lock = new object();
        private ExceptionHandler()
        {
            string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            _StreamWriter = new StreamWriter(Path.Combine(exePath, "ExceptionLog.txt"));
        }

        public static ExceptionHandler Instance
        {
            get
            {
                lock (_Lock)
                {
                    if (_Instance == null)
                    {
                        _Instance = new ExceptionHandler();
                    }
                    return _Instance;
                }
            }
        }
        public void WriteExceptionLog(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss"));
            sb.Append(": ");
            sb.Append(ex.Message);
            sb.Append(ex.InnerException);
            _StreamWriter.WriteLine(sb.ToString());
            _StreamWriter.Flush();
        }

    }
}
