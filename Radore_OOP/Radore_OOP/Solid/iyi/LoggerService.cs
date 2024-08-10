using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Solid.iyi
{
    public class LoggerService
    {

        private readonly ILogger _logger;
        //Constructorına ILogger tipinde bir parametre alır.
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
