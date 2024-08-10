using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public static class OdemeFactory
    {
        public static IOdemeTipi GetOdemeTipi(string odemeTipi)
        {
            Type type = Type.GetType("WinFormsApp." + odemeTipi);
            if (type == null)
            {
                throw new Exception("Ödeme tipi bulunamadı");
            }
            return (IOdemeTipi)Activator.CreateInstance(type);
        }
    }
}
