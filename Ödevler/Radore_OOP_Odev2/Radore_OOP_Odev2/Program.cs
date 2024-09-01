using Radore_OOP_Odev2.Classes;
using Radore_OOP_Odev2.LoggerService;


var bmw = new BMW("i8");
var mercedes = new Mercedes("AMG GT");
var porsche = new Porsche("911");


bmw.Start();
Console.WriteLine("-------------");
mercedes.Start();
Console.WriteLine("-------------");
porsche.Start();
Console.WriteLine("-------------");

Console.WriteLine("Toplam Harcanan Benzin: " + (bmw.BenzinHarca() + mercedes.BenzinHarca() + porsche.BenzinHarca()) + " Litre.");
Console.WriteLine("-------------");

LoggerService logdb = new LoggerService(new DbLogger());
LoggerService logxml = new LoggerService(new XmlLogger());
LoggerService logjson = new LoggerService(new JsonLogger());
logdb.Log("303 nolu hata kodu oluştu");
logxml.Log("303 nolu hata kodu oluştu");
logjson.Log("303 nolu hata kodu oluştu");