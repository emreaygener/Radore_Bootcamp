using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radore_OOP.Interfaces;

namespace Radore_OOP.Classes
{
    public class UsluCocuk :Cocuk, IDinle, IYaz
    {
        public void dinle()
        {
            Console.WriteLine("UsluCocuk dinliyor");
        }

        public void yaz()
        {
            Console.WriteLine("UsluCocuk yaziyor");
        }
    }
}
