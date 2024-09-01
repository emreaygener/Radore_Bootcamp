using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP_Odev2.Classes
{
    public abstract class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public abstract int BenzinHarca();
    }
}
