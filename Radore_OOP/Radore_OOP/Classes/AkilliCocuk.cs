using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radore_OOP.Interfaces;

namespace Radore_OOP.Classes
{
    public class AkilliCocuk : Cocuk, IDinle, IOku, IYaz
    {
        public void dinle()
        {
            Console.WriteLine("AkilliCocuk dinliyor");
        }

        public void oku()
        {
            Console.WriteLine("AkilliCocuk okuyor");
        }

        public void yaz()
        {
            Console.WriteLine("AkilliCocuk yaziyor");
        }
    }
}
