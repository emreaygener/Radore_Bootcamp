using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP_Odev.Classes
{
    public class Mudur : Calisan
    {
        public override int MaasSöyle()
        {
            Console.WriteLine("Müdürün maaşı 60000 TL'dir.");
            return 60000;
        }
    }
}
