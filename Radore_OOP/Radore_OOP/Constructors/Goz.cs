using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Constructors
{
    public class Goz
    {
        public string renk;
        public string retina;
        public string genislik;
        public string yukseklik;

        public Goz(string renk, string retina, string genislik, string yukseklik)
        {
            this.renk = renk;
            this.retina = retina;
            this.genislik = genislik;
            this.yukseklik = yukseklik;
        }
    }
}
