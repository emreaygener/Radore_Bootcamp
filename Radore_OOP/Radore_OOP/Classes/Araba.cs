using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Classes
{
    public class Araba
    {
        public string marka = "";
        public string model = "";
        public int kapisayisi = 4;
        public int penceresayisi = 4;

        public void git(string marka, string model)
        {
            Console.WriteLine( marka+" "+model+" gidiyor");
        }
    }
}
