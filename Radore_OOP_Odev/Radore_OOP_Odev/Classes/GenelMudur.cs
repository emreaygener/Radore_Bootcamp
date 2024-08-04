using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP_Odev.Classes
{
    public class GenelMudur : Calisan
    {
        public override int MaasSöyle()
        {
            Console.WriteLine("Genel Müdürün maaşı 80000 TL'dir.");
            return 80000;
        }
    }
}
