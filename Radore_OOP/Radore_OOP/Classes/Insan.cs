using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radore_OOP.Classes
{
    public class Insan
    {//başlangıç scope'u
        //access modifiers datatype variableName
        public string adi = "ibrahim123";//alfanümerik
        public string soyadi=null;
        public int yas=0; // tam sayısal verileri saklamamızı sağlar
        public double maas=0.14; //ondalıklı sayısal verileri saklamamızı sağlar
        public bool cinsiyet=true; //true/false

        //metotlar 2ye ayrılırlar geriye değer döndüren ve döndürmeyen şeklinde

        //access modifiers geri dönüş tipi metotAdi(parametreler){}
        public void uyu(string isim, string soyisim)
        {
            Console.WriteLine(isim+" "+soyisim + " uyuyor");
        }

        public void ekranaYaz(string isim, string soyisim)
        {
            Console.WriteLine("kişinin adı "+isim+" kişinin soyadı "+ soyisim );
        }

        //boş constructor
        // class ismi ile aynı ve geri dönüş tüpü olmayan metotlara constructor denir.
        public Insan()
        {
            
        }
        //parametreli constructor
        public Insan(string adi, string soyadi)
        {
            this.adi = adi;
            this.soyadi = soyadi;
        }
        public Insan(string adi, string soyadi, int yas, double maas, bool cinsiyet)
        {
            this.adi = adi;
            this.soyadi = soyadi;
            this.yas = yas;
            this.maas = maas;
            this.cinsiyet = cinsiyet;
        }
        
    }//bitiş scope'u
}
