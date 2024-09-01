using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LogForm
{
    public class LogFactory
    {
        public ILogger ReturnInstance(string logType)
        {
            var instance = Assembly.GetAssembly(typeof(ILogger)).CreateInstance("LogForm." + logType);

            return (ILogger)instance;
        }
    }
}
