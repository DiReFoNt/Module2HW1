using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public class Logger
    {
        private DateTime _logTime;
        private string _logType;
        private string _logText;
        private string _log;
        private List<string> _logWorkResult = new List<string>();

        private static readonly Logger _instance = new Logger();
        static Logger()
        {
        }

        private Logger()
        {
            _logTime = DateTime.Now;
        }

        public static Logger Instance
        {
            get { return _instance; }
        }

        // changing the log type
        public void LogType(string type)
        {
            _logType = type;
        }

        // changing the log text
        public void LogText(string text)
        {
            _logText = text;
        }

        // changing the log time
        public void LogTime(DateTime time)
        {
            _logTime = time;
        }

        // write log to memory
        public string NewLog()
        {
            _logWorkResult.Add(_log);
            return _log = $"{_logTime}: {_logType}: {_logText}";
        }

        // log report
        public List<string> GetLogWorkResult()
        {
            return _logWorkResult;
        }
    }
}
