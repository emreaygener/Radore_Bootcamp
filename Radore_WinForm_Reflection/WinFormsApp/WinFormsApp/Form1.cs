using System.Data.SqlClient;

namespace WinFormsApp
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //OdemeIslemi odemeIslemi;
            //string mesaj;
            //if (secilenOdemeTipi == "KrediKarti")
            //{
            //    odemeIslemi = new OdemeIslemi(new KrediKarti());
            //    mesaj=odemeIslemi.OdemeYap(tutar);
            //    lblSonuc.Text = mesaj;
            //}
            //else if (secilenOdemeTipi == "ApplePay")
            //{
            //    odemeIslemi = new OdemeIslemi(new ApplePay());
            //    mesaj = odemeIslemi.OdemeYap(tutar);
            //    lblSonuc.Text = mesaj;
            //}
            //else if (secilenOdemeTipi == "MailOrder")
            //{
            //    odemeIslemi = new OdemeIslemi(new MailOrder());
            //    mesaj = odemeIslemi.OdemeYap(tutar);
            //    lblSonuc.Text = mesaj;
            //}
            //else
            //{
            //    odemeIslemi = new OdemeIslemi(new KrediKarti());
            //}

            // Factory Design Pattern ve Reflection kullanarak çözülecek
            if(cmbOdemeTipi.SelectedItem == null || cmbOdemeTipi.SelectedItem.ToString() == "Seciniz")
            {
                MessageBox.Show("Ödeme tipi seçiniz");
                return;
            } 
            else if(string.IsNullOrEmpty(txtTutar.Text))
            {
                MessageBox.Show("Tutar giriniz");
                return;
            }
            else
            {
                var secilenOdemeTipi = cmbOdemeTipi.SelectedItem.ToString();
            
                double tutar = Convert.ToDouble(txtTutar.Text);
            
                var factory = new OdemeFactory();
                
                var odemeIslemi = factory.NesneOlustur(secilenOdemeTipi);

                lblSonuc.Text = odemeIslemi.ode(tutar);

            }

            // https://ttdijitaldepokurumsal.turktelekom.com.tr/app/tr-TR/Dosya/Paylas/TT/209ecb53-4011-426b-881f-78da2a5cfb51

            // ödeme yönteminin benzeri gerçekleştirilecek console application ı görselleştireceğiz ödeme yönteminin jhemen hemen aynı ikinci bir form

            // log tipi dropdown
            // durum 303 nolu hata kodu oluştu
            // 303 nolu hata kodu oluştu dbye kaydedildi
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
