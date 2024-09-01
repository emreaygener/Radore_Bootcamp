using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP_Odev.Classes
{
    public class Stajyer : Calisan
    {
        public override int MaasSöyle()
        {
            Console.WriteLine("Stajyerin maaşı 5000 TL'dir.");
            return 5000;
        }
    }
}
