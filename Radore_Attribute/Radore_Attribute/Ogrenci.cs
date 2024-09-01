using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_Attribute
{
    public class Ogrenci
    {
        [ZorunluAlan]
        public string Ad;
        [ZorunluAlan]
        public string Soyad;
        [ZorunluAlan]
        public string Bolum;
    }
}
