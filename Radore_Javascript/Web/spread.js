function yazdir() {
  const meyveler = ["Elma", "Armut", "Karpuz", "Muz"];
  console.log(meyveler);
}

function kopyalama() {
  const meyveler = ["Elma", "Armut", "Karpuz", "Muz"];
  const kopya = [...meyveler];
  console.log(kopya);
  meyveler.push("Kiraz");
  console.log(meyveler);
  console.log(kopya);
}

function NesneKopyalama() {
  const insan = {
    ad: "Ahmet",
    soyad: "Yılmaz",
    yas: 30,
  };
  const kopya = { ...insan };
  console.log(kopya);
  insan.yas = 35;
  console.log(insan);
  console.log(kopya);
}

function DiziBirlestirme() {
  const erkekIsimleri = ["Ahmet", "Mehmet", "Ali"];
  const kadinIsimleri = ["Ayşe", "Fatma", "Zeynep"];
  const birlesikDizi = [...erkekIsimleri, ...kadinIsimleri];
  console.log(birlesikDizi);
}

function ObjeBirlestirme() {
  const kullanici = {
    ad: "Ahmet",
    soyad: "Yılmaz",
  };
  const evcilHayvanlar = {
    kopek: "Karabaş",
    kedi: ["Tekir", "Pamuk"],
  };
  const birlesikObj = { ...kullanici, ...evcilHayvanlar };
  console.log(birlesikObj);
}

function KareAl(...sayilar) {
  return sayilar.map((sayi) => sayi * sayi);
}

function SonsuzParametre() {
  console.log(KareAl(15, 21, 34, 42, 51));
}

function KarakterYazdirma() {
  const kelime = "Merhaba";
  console.log([...kelime]);
}

function Destructuring() {
  const kullanici = {
    ad: "Ahmet",
    soyad: "Yılmaz",
    yas: 30,
    meslek: "Öğretmen",
  };
  const { ad, soyad, ...digerleri } = kullanici;
  console.log(digerleri);
  console.log(ad, soyad, digerleri.meslek);
}
