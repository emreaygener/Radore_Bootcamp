using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP_Odev.Classes
{
    public class Programci : Calisan
    {
        public override int MaasSöyle()
        {
            Console.WriteLine("Programcının maaşı 40000 TL'dir.");
            return 40000;
        }
    }
}
