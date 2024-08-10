namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string secilenOdemeTipi = cmbOdemeTipi.SelectedItem.ToString();
            double tutar = Convert.ToDouble(txtTutar.Text);
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

            try
            {
                OdemeIslemi odemeIslemi = new(OdemeFactory.GetOdemeTipi(secilenOdemeTipi));
                lblSonuc.Text = odemeIslemi.OdemeYap(tutar);
            }
            catch (Exception ex)
            {
                lblSonuc.Text = "Geçersiz ödeme tipi seçildi";
            }

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
