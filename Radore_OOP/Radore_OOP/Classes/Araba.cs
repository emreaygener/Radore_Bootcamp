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
        public int fiyat = 0;

        public Araba()
        {
        }
        public Araba(string marka, string model, int kapisayisi, int penceresayisi, int fiyat)
        {
            this.marka = marka;
            this.model = model;
            this.kapisayisi = kapisayisi;
            this.penceresayisi = penceresayisi;
            this.fiyat = fiyat;
        }

        public void git(string marka, string model)
        {
            Console.WriteLine( marka+" "+model+" gidiyor");
        }
    }
}
