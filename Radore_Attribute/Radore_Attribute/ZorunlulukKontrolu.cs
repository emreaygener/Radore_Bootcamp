using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Radore_Attribute
{
    public static class ZorunlulukKontrolu
    {
        public static bool Dogrula(object dogrulanacakNesne)
        {
            Type tip = dogrulanacakNesne.GetType();
            // İlgili gelen nesnenin tüm alanlarını alıyoruz.
            FieldInfo[] dogrulanacakAlanlar = tip.GetFields(BindingFlags.Instance|BindingFlags.Public);
            foreach (FieldInfo dogrulanacakAlan in dogrulanacakAlanlar)
            {
                object[] zorunluAlanOznitelikleri = dogrulanacakAlan.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);
                if (zorunluAlanOznitelikleri.Length != 0)
                {
                    string alanDegeri = dogrulanacakAlan.GetValue(dogrulanacakNesne) as string;
                    if (string.IsNullOrEmpty(alanDegeri))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
