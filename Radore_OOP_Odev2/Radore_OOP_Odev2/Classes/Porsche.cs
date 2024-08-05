using Radore_OOP_Odev2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP_Odev2.Classes
{
    public class Porsche : Araba, ICokhizliGit
    {
        public Porsche(string Model)
        {
            this.Marka = "Porsche";
            this.Model = Model;
        }
        public override int BenzinHarca()
        {
            Console.WriteLine("Porsche 80 litre benzin harcar.");
            return 80;
        }

        public void CokhizliGit()
        {
            Console.WriteLine($"{Marka} cok hizli gider.");
        }

        public void Start()
        {
            CokhizliGit();
        }
    }
}
