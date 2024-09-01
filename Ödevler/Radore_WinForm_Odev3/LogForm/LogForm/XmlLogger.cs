using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForm
{
    public class XmlLogger : ILogger
    {
        public string Log(string message)
        {
            return(message + " xml e kaydedildi.");
        }
    }
}
