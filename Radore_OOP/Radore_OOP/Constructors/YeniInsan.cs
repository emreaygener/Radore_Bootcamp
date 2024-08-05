using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Constructors
{
    public class YeniInsan
    {
        public string adi;
        public string soyadi;
        public Kafa kafa;

        public YeniInsan(string adi, string soyadi, Kafa kafa)
        {
            this.adi = adi;
            this.soyadi = soyadi;
            this.kafa = kafa;
        }

        public void randevuKayit()
        {
            Console.WriteLine("Randevu alan kişinin adı " + adi +
                                " soyadı " + soyadi +
                                " göz rengi " + kafa.goz.renk +
                                " burnu " + kafa.burun.tip +
                                " kulağı " + kafa.kulak.sekil 
                );
        }
    }
}
