using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP_Odev.Classes
{
    public abstract class Calisan
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int Maas { get; set; }
        public abstract int MaasSöyle();
    }
}
