using Radore_OOP.Classes;
using Radore_OOP.Constructors;
using Radore_OOP.Constructors2;
using Radore_OOP.Overrides;
using Radore_OOP.Solid.iyi;
using Radore_OOP.Solid.kotu;
using System.Collections;

Console.WriteLine("Hello, World!");


//ClassIsmi nesneAdi = new ClassAdı();
Insan i = new Insan();
i.adi = "ibrahim";
i.soyadi = "gökyar";
i.yas = 46;
i.maas = 3.14;
i.cinsiyet = true;
i.uyu(i.adi,i.soyadi);


Araba a = new Araba();
a.marka = "ford";
a.model = "focus";
a.kapisayisi = 4;
a.penceresayisi = 4;
a.git(a.marka,a.model);

Anne an = new Anne();
an.adi = "fahriye";
an.soyadi = "gökyar";
an.yas = 60;
an.maas = 3.14;
an.cinsiyet = false;
an.uyu(an.adi,an.soyadi);

// kişinin adı anneadı kişinin soyadı annesoyadı - anne
// kişinin adı babaadı kişinin soyadı babasoyadı - baba
// kişinin adı çocukadı kişinin soyadı cocuksoyadı - çocuk

// bu 3 mesajı kalıtım kullanarak ekrana nasıl yazdırırdınız? 
// Anne,Baba ve Çocuk sınıflarını Insan sınıfından türetir, insan sınıfına IsimYaz(isim,soyisim){Console.WriteLine($"{mesaj}")} metotunu ekler ve bu metotu override IsimYaz(isim,soyisim){Console.WriteLine($"{mesaj} -anne")} ederdim.Polymorphism kullanarak ekrana yazdırırdım. 

Anne anne = new Anne();
anne.adi = "Ayşe";
anne.soyadi = "Fatma";
anne.ekranaYaz(anne.adi,anne.soyadi);
anne.oku();
anne.yaz();


Baba baba = new Baba();
baba.adi = "Ali";
baba.soyadi = "Veli";
baba.ekranaYaz(baba.adi, baba.soyadi);
baba.oku();
baba.dinle();

Cocuk cocuk = new Cocuk();
cocuk.adi = "Mert";
cocuk.soyadi = "Kaya";
cocuk.ekranaYaz(cocuk.adi,cocuk.soyadi);

//---soru2

//Hakan Yılmaz akıllıdır	-Akıllcıcocuk
//Mehmet yıldız usludur.  - UsluCocuk


//bu 2 mesajı yine kalıtımı kullanarak yazmamız gerekse

//çocuk sınıfından kalıtım alan akıllıcocuk ve uslucocuk sınıflarını oluşturur ve classlara özel metotlar tanımlardım. böylelikle anne ve baba classları erişemezdi.

AkilliCocuk ak = new ();
ak.adSoyadSifatYaz("Hakan","Yılmaz","Akıllıdır");
ak.oku();
ak.yaz();
ak.dinle();

UsluCocuk us = new ();
us.adi = "Mehmet";
us.soyadi = "Yıldız";
us.sifat = "Usludur";
us.adSoyadSifatYaz(us.adi,us.soyadi,us.sifat);

us.yaz();
us.dinle();


// solid prensipleri link : https://gokhana.medium.com/solid-nedir-solid-yaz%C4%B1l%C4%B1m-prensipleri-nelerdir-40fb9450408e

Matematik m = new Matematik();
int gelenDeger = m.topla(5, 6);
Console.WriteLine("Toplam: " + gelenDeger);
Console.WriteLine("Fark: "+ m.cikar(5, 6));
Console.WriteLine("Çarpım: "+ m.carp(5, 6));
Console.WriteLine("Bölüm: " + m.bol(54, 6));

//---soru3 ödev

// bir şirketimiz
// GenelMüdür 80000
// Müdür 50000
// Programcı 30000
// Stajyer 20000

// Bu şirketteki çalışanların maaşlarını hesaplayıp ekrana nasıl yazdırırdınız?

// Soru 4 ödev abstract class nedir?

// Abstract çalışan sınıfı oluşturuldu.abstract maasSöyle metodu eklendi. genel müdür, müdür, programcı ve stajyer sınıfları bu çalışan sınıfından türetilip maasSöyle metodu override edildi. MaasHesaplama static sınıfı ToplamMaasYazdır metodu ile çalışanların maaşlarını toplam maaşı yazdırıldı. params ile parametreler verilip sum metodu ile toplandı.

//Abstract sınıf: Abstract sınıflar, diğer sınıflar tarafından kalıtım alınmak üzere tasarlanmış sınıflardır. Abstract sınıflar, içerisinde abstract metotlar, propertyler ve normal metotlar barındırabilirler. Abstract sınıflardan nesne oluşturulamaz. Abstract sınıflar, kalıtım alınmak üzere tasarlandıkları için, içerisinde abstract metotlar barındırabilirler. Abstract metotlar, sadece imza olarak tanımlanır ve gövdesi olmaz ve sadece abstract sınıflar içinde tanımlanabilir.

// Kalıtım vermek için tasarlandıkları için katılım verdikleri sınıfları kendi implementasyonlarını yapmaya zorlarlar. 

// Mesela bif futbolcu abstract classını ele alalım. koş, pas, şut, top çalma gibi metotlarımız olsun. Bu metotlar her futbolcunun yapması gereken işlemlerdir. Ancak her futbolcu farklı görev tanımına sahiptir. GöreviniYap metodu abstract olarak tanımlanabilir. Bu metotu her futbolcu kendi görevine göre implemente eder. böylelikle koş pas şut gibi metotları tekrar tekrar yazılmazken kalıtım verilen sınıfların içinde erişilebilir olur. her mevki oyuncusu için sadece görevini yap metodunu implemente etmek yeterli olur.

//şemadaki gibi olabilir:

// abstract futbolcu : { 
//        koş(): void,
//        pas(): void,
//        şut(): void,
//        topÇalma(): void,
//        abstract göreviniYap(): void
//}
//    stoper : futbolcu {
//        göreviniYap(): void {
//        kaleyisavun();
//        ayaktaKal();
//        hücumsırasındaöneyaklaş();
//        }
//    }

GenelMudur gm = new GenelMudur();
Mudur mu = new Mudur();
Programci p = new Programci();
Stajyer s = new Stajyer();

double toplamMaas = 0;
toplamMaas += gm.maasinizNedir();
toplamMaas += mu.maasinizNedir();
toplamMaas += p.maasinizNedir();
toplamMaas += s.maasinizNedir();
Console.WriteLine("Toplam Maaş: " + toplamMaas + " TL maaş alıyorlar.");

//---soru5 ödev
//interface için
// bmw mercedes 			porche
//bmw havada uçuyor		mercedes havada uçuyor 		porsche çok hızlı gidiyor
//bmw denizde yüzüyor		mercedes denizde yüzüyor	
//bmw çok hızlı gidiyor


// bu mesajları interface yada interface leri kullanarak ekrana nasıl yazdırırdınız.

//Soru 6 ödev

//abstract class

// bmw 60.0 Litre mercedes 70.0 litre		porche 80.0 litre

// toplamda ne kadar benzin harcıyorlar. 


// https://dogan-ay.medium.com/design-patterns-tasar%C4%B1m-kal%C4%B1plar%C4%B1-nedir-2d0e3d44874
// https://www.digitalocean.com/community/tutorials/java-singleton-design-pattern-best-practices-examples
// https://www.gokhan-gokalp.com/en/stack-heap-kavramlari/

Insan i2 = new Insan("hakan","yilmaz");
Insan i3 = new Insan("metin","yildiz",44,3.14,true);

// https://medium.com/@mstfkrky011/javada-s%C4%B1n%C4%B1flar-aras%C4%B1-i%CC%87li%C5%9Fkiler-fa7f69885e26
// https://medium.com/@bbusrayildizz34/s%C4%B1n%C4%B1flar-aras%C4%B1-i%CC%87li%C5%9Fkiler-composition-aggregation-association-inheritance-5d1639bd9a4


Goz goz = new Goz("Kahverengi","retina","30","30");
Kulak kulak = new Kulak("Geniş");
Burun burun = new Burun("Kemerli");
Kafa kafa = new Kafa(goz,kulak,burun);
YeniInsan yeniInsan = new YeniInsan("İbrahim","Gökyar",kafa);
yeniInsan.randevuKayit();


//public Araba(string marka, string model, int kapisayisi, int penceresayisi, int fiyat)
//{
//    this.marka = marka;
//    this.model = model;
//    this.kapisayisi = kapisayisi;
//    this.penceresayisi = penceresayisi;
//    this.fiyat = fiyat;
//}
Araba araba = new Araba("BMW","X5",4,4, 2000000);
Console.WriteLine($"Arabanın markası: {araba.marka} modeli: {araba.model} kapı sayısı: {araba.kapisayisi} pencere sayısı: {araba.penceresayisi} fiyatı: {araba.fiyat} TL");

YeniAraba yeniAraba = new YeniAraba
(
    new Kasa
    (
        new Marka("Mercedes"),new Model("C180"),new Kapi(4),new Pencere(4),"Sedan"
    )
    ,2000000
);

yeniAraba.SiparisVer();


//diziler
//1.yöntem
string[] gunler = new string[7];
gunler[0] = "Pazartesi";
gunler[1] = "Salı";
gunler[2] = "Çarşamba";
gunler[3] = "Perşembe";
gunler[4] = "Cuma";
gunler[5] = "Cumartesi";
gunler[6] = "Pazar";

for (int ii = 0; ii < gunler.Length; ii++)
{
    Console.WriteLine(gunler[ii]);
}

//2.yöntem
//burada dizi büyüklükleri tanımlı jste değişken nasıl oluyor

int[] sayilar = { 2, 4, 6, 7, 9, 11, 22, 33, 44, 55, 66 };
int toplam = 0;
for (int ii = 0; ii < sayilar.Length; ii++)
{
    toplam+=sayilar[ii];
}
Console.WriteLine("Sayıların toplamı: " + toplam);


//içinde çalışan tipinde veri alan bir dizimiz olsun ve tüm çalışanların toplam ne kadar maaş aldıklarını ekrana yazdıralım.
Calisan[] calisanlar = { gm, mu, p, s };
toplamMaas = 0;
foreach (Calisan calisan in calisanlar)
{
    toplamMaas += calisan.maasinizNedir();
}
Console.WriteLine("Toplam Maaş: " + toplamMaas + " TL maaş alıyorlar.");

//  peki xml in json a göre avantajları dezavantajları nedir


// https://www.mshowto.org/java-collection-framework-nedir-framework-bilesenleri-ne-ise-yarar-peki-amaci.html
ArrayList liste = new ArrayList();
liste.Add("ibrahim");
liste.Add(35);
liste.Add(true);
liste.Insert(0, "i");

if(liste.Contains("ibrahim"))
{
    Console.WriteLine("Listede ibrahim var");
}
else
{

   Console.WriteLine("Listede ibrahim yok");
}
//generic class lar boxing ve unboxing işlemlerin performans kaybını da engeller
// List<T> 
List<string> liste2 = new List<string>();
liste2.Add("ibrahim");
liste2.Add("gökyar");

// içine personel tipinde veri alan bir liste olsun bu listenin içine 3 tane personel ekleyelim ve tüm personellerin adını soyadını maaşını ve toplam ne kadar maaş aldıklarını ekrana yazdıralım.



List<Personel> personeller = new List<Personel>();
personeller.Add(new Personel("metin", "yıldız", 30000));
personeller.Add(new Personel("hakan", "yılmaz", 50000));
personeller.Add(new Personel("mehmet", "yıldız", 70000));
toplamMaas = 0;

foreach (Personel personel in personeller)
{
    Console.WriteLine($"Personel adı: {personel.adi} soyadı: {personel.soyadi} maaşı: {personel.maas}");
    toplamMaas += personel.maas;
}

Console.WriteLine("Toplam Maaş: " + toplamMaas + " TL maaş alıyorlar.");

DbLog dbLog = new DbLog();
XmlLog xmlLog = new XmlLog();
JsonLog jsonLog = new JsonLog();
Logger logger = new Logger(dbLog,xmlLog,jsonLog);
logger.LogKaydet(LogType.Xml, "303 nolu hata kodu oluştu");
logger.LogKaydet(LogType.Db, "303 nolu hata kodu oluştu");
logger.LogKaydet(LogType.Json, "303 nolu hata kodu oluştu");

//https://gokhana.medium.com/solid-nedir-solid-yaz%C4%B1l%C4%B1m-prensipleri-nelerdir-40fb9450408e

// Yeni bir log sistemini logger classını hiçbir şekilde değiştirmeden yeni bir log formatını sisteme ekleyelim.

LoggerService logdb = new LoggerService(new DbLogger());
LoggerService logxml = new LoggerService(new XmlLogger());
LoggerService logjson = new LoggerService(new JsonLogger());
logdb.Log("303 nolu hata kodu oluştu");
logxml.Log("303 nolu hata kodu oluştu");
logjson.Log("303 nolu hata kodu oluştu");

Child c = new Child();
c.yaz();