using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForm
{
    public interface ILogger
    {
        string Log(string message);
    }
}
