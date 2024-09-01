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

            OdemeTipiGetir();

        }

        public void OdemeTipiGetir()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RadoreDb;Integrated Security=SSPI;";
            List<OdemeTipi> odemeTipleri = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sorgu = "SELECT * FROM OdemeTipleri";
                    //new query alanını açtık
                    SqlCommand command = new SqlCommand(sorgu, connection);
                    //execute buttonuna basmış olduk
                    SqlDataReader reader = command.ExecuteReader();
                    odemeTipleri = new List<OdemeTipi>();
                    odemeTipleri.Add(new OdemeTipi
                    {
                        Id = -1,
                        className = "Seciniz",
                        displayName = "Ödeme Tipi Seçiniz"
                    });
                    //read metodundan true geliyorsa o zaman ilgili satırdayım
                    while (reader.Read())
                    {
                        odemeTipleri.Add(new OdemeTipi
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            className = (string)reader["CLASS_NAME"],
                            displayName = (string)reader["DISPLAY_NAME"]
                        });
                    }
                    //10 tane ödeme tipi şeklinde veri alan listenin içinde elemanımız olacak

                }
                catch (Exception ex)
                {

                    Console.WriteLine("Hata oluştu : " + ex.ToString());
                }
                finally
                {
                    connection.Close();
                }

                cmbOdemeTipi.DataSource = odemeTipleri;
                cmbOdemeTipi.DisplayMember = "displayName";
                cmbOdemeTipi.ValueMember = "className";

            }
        }

        private void lblTutar_Click(object sender, EventArgs e)
        {
            txtTutar.Focus();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
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
            if (cmbOdemeTipi.SelectedItem == null || Convert.ToString(cmbOdemeTipi.SelectedValue) == "Seciniz")
            {
                MessageBox.Show("Ödeme tipi seçiniz");
                return;
            }
            else if (string.IsNullOrEmpty(txtTutar.Text))
            {
                MessageBox.Show("Tutar giriniz");
                return;
            }
            else
            {
                var secilenOdemeTipi = Convert.ToString(cmbOdemeTipi.SelectedValue);

                double tutar = Convert.ToDouble(txtTutar.Text);

                var factory = new OdemeFactory();
                if(secilenOdemeTipi != null)
                {
                    var odemeIslemi = factory.NesneOlustur(secilenOdemeTipi);
                    lblSonuc.Text = odemeIslemi.ode(tutar);
                }
                //Yeni ödeme yöntemi ekleyince dinamik olarak classı da nasıl oluşturabilirim araiştırılacak ÖDev
                // system io
            }

            // https://ttdijitaldepokurumsal.turktelekom.com.tr/app/tr-TR/Dosya/Paylas/TT/209ecb53-4011-426b-881f-78da2a5cfb51

            // ödeme yönteminin benzeri gerçekleştirilecek console application ı görselleştireceğiz ödeme yönteminin jhemen hemen aynı ikinci bir form

            // log tipi dropdown
            // durum 303 nolu hata kodu oluştu
            // 303 nolu hata kodu oluştu dbye kaydedildi
        }

        private void lblSonuc_Click(object sender, EventArgs e)
        {

        }

        private void lblOdemeTipi_Click(object sender, EventArgs e)
        {
            cmbOdemeTipi.Focus();
        }
    }
}
