// See https://aka.ms/new-console-template for more information
using Radore_Attribute;

Console.WriteLine("Hello, World!");

Ogrenci ogrenci = new Ogrenci();
ogrenci.Ad = "Ali";
ogrenci.Soyad = "Veli";
ogrenci.Bolum = "Bilgisayar Mühendisliği";

Araba araba = new Araba();

// Classlibrary ye çevir Ödev

if (!ZorunlulukKontrolu.Dogrula(araba))
{
    Console.WriteLine("Öğrenci bilgileri girilmesi zorunludur.");
}
else
{
    Console.WriteLine("Zorunlu alanlar doldurulmuştur.");
}