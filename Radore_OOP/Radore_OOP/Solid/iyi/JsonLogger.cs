using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Solid.iyi
{
    internal class JsonLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message + " json a kaydedildi.");
        }
    }
}
