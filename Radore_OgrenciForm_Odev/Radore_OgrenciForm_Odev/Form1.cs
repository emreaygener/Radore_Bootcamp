using Radore_AttributeClassLibrary_Odev;

namespace Radore_OgrenciForm_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = txtAd.Text;
            ogrenci.Soyad = txtSoyad.Text;
            ogrenci.Bolum = txtBolum.Text;

            if (!ZorunlulukKontrolu.Dogrula(ogrenci))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
            else
            {
                lblSonuc.Text = "Ad: " + ogrenci.Ad + " Soyad: " + ogrenci.Soyad + " Bölüm: " + ogrenci.Bolum + ". Kayıt gerçekleştirildi.";
                MessageBox.Show("Öğrenci bilgileri kaydedildi.");
            }
        }
    }
}
