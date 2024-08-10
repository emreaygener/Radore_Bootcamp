using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace WinFormsApp
{
    public class OdemeFactory
    {
        //public static IOdemeTipi GetOdemeTipi(string odemeTipi)
        //{
        //    Type type = Type.GetType("WinFormsApp." + odemeTipi);
        //    if (type == null)
        //    {
        //        throw new Exception("Ödeme tipi bulunamadı");
        //    }
        //    return (IOdemeTipi)Activator.CreateInstance(type);
        //}

        public IOdemeTipi NesneOlustur(string className)
        {
            //OdemeForm projesi içindek sana parametre olarak gelen className ile ilgili bir class var ise
            //ondan runtime dinamik olarak bir nesne oluştur
            //oluşturdunğun nesneyi de IOdemeTipi cast ederek oluştur. 
            var newInstance = Assembly.GetAssembly(typeof(IOdemeTipi)).CreateInstance("WinFormsApp." + className);
            return (IOdemeTipi)newInstance;
        }
    }
}
