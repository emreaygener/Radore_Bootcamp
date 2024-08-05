using Radore_OOP_Odev2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP_Odev2.Classes
{
    public class Mercedes : Araba, IHavadaUcDenizdeYuz
    {
        public Mercedes(string Model)
        {
            this.Marka = "Mercedes";
            this.Model = Model;
        }
        public override int BenzinHarca()
        {
            Console.WriteLine("Mercedes 70 litre benzin harcar.");
            return 70;
        }

        public void DenizdeYuz()
        {
            Console.WriteLine($"{Marka} denizde yüzer.");
        }

        public void HavadaUc()
        {
            Console.WriteLine($"{Marka} havada uçar.");
        }

        public void Start()
        {
            HavadaUc();
            DenizdeYuz();
        }
    }
}
