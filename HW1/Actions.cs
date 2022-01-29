using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public class Actions
    {
        private Result _results = new Result();
        public Result Info(Logger logger)
        {
            logger.LogText("Start method");
            logger.LogType("Info");
            logger.NewLog();
            return new Result { Status = true };
        }

        public Result Warning(Logger logger)
        {
            logger.LogText("Skipped logic in method");
            logger.LogType("Warning");
            logger.NewLog();
            return new Result { Status = true };
        }

        public Result Error(Logger logger)
        {
            return new Result { Status = false, Text = "I broke a logic" };
        }
    }
}
