using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public class Actions
    {
        public Result Info(Logger logger)
        {
            logger.NewLog(DateTime.Now, "Info", "Start method");
            return new Result { Status = true };
        }

        public Result Warning(Logger logger)
        {
            logger.NewLog(DateTime.Now, "Warning", "Skipped logic in method");
            return new Result { Status = true };
        }

        public Result Error(Logger logger)
        {
            return new Result { Status = false, Text = "I broke a logic" };
        }
    }
}
