using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radore_OOP.Interfaces;

namespace Radore_OOP.Classes
{
    public class Baba : Insan,IOku,IDinle
    {
        public void dinle()
        {
            Console.WriteLine("Baba dinliyor...");
        }

        public void oku()
        {
            Console.WriteLine("Baba okuyor...");
        }
    }
}
