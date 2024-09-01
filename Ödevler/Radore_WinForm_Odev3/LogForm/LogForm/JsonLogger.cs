using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForm
{
    internal class JsonLogger : ILogger
    {
        public string Log(string message)
        {
            return message + " json a kaydedildi.";
        }
    }
}
