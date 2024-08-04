using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radore_OOP.Interfaces;

namespace Radore_OOP.Classes
{
    // Anne sınıfı Insan sınıfından türemiştir.
    //Anne classı insan classındaki public olan tüm özellik ve metotları kullanabilir.
    public class Anne : Insan, IOku, IYaz
    {
        public void oku()
        {
            Console.WriteLine("Anne okuyor...");
        }
        public void yaz()
        {
            Console.WriteLine("Anne yazıyor...");
        }
    }
}
