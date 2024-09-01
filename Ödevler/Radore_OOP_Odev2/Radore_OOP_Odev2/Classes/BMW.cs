using Radore_OOP_Odev2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP_Odev2.Classes
{
    public class BMW : Araba, IHavadaUcDenizdeYuzCokHizliGit
    {
        public BMW(string Model)
        {
            this.Marka = "BMW";
            this.Model = Model;
        }
        public override int BenzinHarca()
        {
            Console.WriteLine("BMW 60 litre benzin harcar.");
            return 60;
        }

        public void CokhizliGit()
        {
            Console.WriteLine($"{Marka} cok hizli gider.");
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
           CokhizliGit();
        }
    }
}
