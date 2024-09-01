using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radore_OOP_Odev2.Interfaces;

namespace Radore_OOP_Odev2.LoggerService
{
    public class DbLogger :ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message + " db e kaydedildi.");
        }

    }
}
