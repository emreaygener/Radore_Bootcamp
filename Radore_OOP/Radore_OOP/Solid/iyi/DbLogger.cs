using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Solid.iyi
{
    public class DbLogger :ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message + " db e kaydedildi.");
        }

    }
}
