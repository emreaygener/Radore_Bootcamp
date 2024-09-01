using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForm
{
    public class LoggerService
    {

        private readonly ILogger _logger;
        //Constructorına ILogger tipinde bir parametre alır.
        public LoggerService(ILogger logger)
        {
            _logger = logger;
        }

        public string Log(string message)
        {
            return _logger.Log(message);
        }
    }
}
