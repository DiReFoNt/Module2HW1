using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW1
{
    public class Starter
    {
        private Actions _action = new Actions();
        private Random _rand = new Random();
        private Result _result = new Result { Status = true };
        private Logger _logger = Logger.Instance;
        public void Run()
        {
            Console.WriteLine("Process started successfully");
            for (int i = 0; i <= 100; i++)
            {
                int randomNumber = _rand.Next(1, 4);
                if (_result.Status == true)
                {
                    switch (randomNumber)
                    {
                        case 1:
                            _result = _action.Info(_logger);
                            break;
                        case 2:
                            _result = _action.Warning(_logger);
                            break;
                        case 3:
                            _result = _action.Error(_logger);
                            break;
                    }
                }

                if (_result.Status == false)
                {
                    _logger.NewLog(DateTime.Now, "Error", $"Action failed by a reason {_result.Text}");
                    _result.Status = true;
                }
            }

            // turning a log into a string
            string[] workResult = _logger.GetLogWorkResult();
            string result = string.Join("\n", workResult);

            // writing log to file
            File.WriteAllText("log.txt", result);
            Console.WriteLine("Process completed successfully");
        }
    }
}
