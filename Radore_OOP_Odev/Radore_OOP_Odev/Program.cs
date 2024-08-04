using Radore_OOP_Odev.Classes;


Calisan genelMudur = new GenelMudur();
Calisan mudur = new Mudur();
Calisan programci = new Programci();
Calisan stajyer = new Stajyer();

MaasHesaplama.ToplamMaasYazdır(genelMudur.MaasSöyle(), mudur.MaasSöyle(), programci.MaasSöyle(), stajyer.MaasSöyle());

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