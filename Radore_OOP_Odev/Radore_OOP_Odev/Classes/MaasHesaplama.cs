using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP_Odev.Classes
{
    public static class MaasHesaplama
    {
        public static void ToplamMaasYazdır(params int[]maaslar)
        {
            Console.WriteLine("Toplam maaş: "+maaslar.Sum());
            
        }
    }
}
