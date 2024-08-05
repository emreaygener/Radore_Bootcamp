using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radore_OOP_Odev2.Interfaces;

namespace Radore_OOP_Odev2.LoggerService
{
    internal class JsonLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message + " json a kaydedildi.");
        }
    }
}
