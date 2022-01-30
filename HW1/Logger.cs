using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public class Logger
    {
        private static int _index = 0;
        private string _log;
        private string[] _logWorkResult = new string[1000];
        private static readonly Logger _instance = new Logger();
        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance
        {
            get { return _instance; }
        }

        // write log to memory
        public string NewLog(DateTime date, string logType, string logText)
        {
            _log = $"{date}: {logType}: {logText}";
            _logWorkResult[_index] = _log;
            Console.WriteLine(_log);
            ++_index;
            return _log;
        }

        // log report
        public string[] GetLogWorkResult()
        {
            return _logWorkResult;
        }
    }
}
