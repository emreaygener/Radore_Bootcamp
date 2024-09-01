using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radore_OOP_Odev2.Interfaces;

namespace Radore_OOP_Odev2.LoggerService
{
    public class LoggerService
    {

        private readonly ILogger _logger;

        public LoggerService(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(string message)
        {
            _logger.Log(message);
        }
    }
}
