using Radore_OOP.Classes;

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