using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Constructors2
{
    public class Kasa
    {
        public Marka marka;
        public Model model;
        public Kapi kapi;
        public Pencere pencere;
        public string kasaTipi;
        public Kasa(Marka marka, Model model, Kapi kapi, Pencere pencere, string kasaTipi)
        {
            this.marka = marka;
            this.model = model;
            this.kapi = kapi;
            this.pencere = pencere;
            this.kasaTipi = kasaTipi;
        }
    }
}
