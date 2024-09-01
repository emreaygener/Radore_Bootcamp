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
                    SqlCommand command = new SqlCommand(sorgu, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    odemeTipleri = new List<OdemeTipi>();
                    odemeTipleri.Add(new OdemeTipi
                    {
                        Id = -1,
                        className = "Seciniz",
                        displayName = "Ödeme Tipi Seçiniz"
                    });
                    while (reader.Read())
                    {
                        odemeTipleri.Add(new OdemeTipi
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            className = (string)reader["CLASS_NAME"],
                            displayName = (string)reader["DISPLAY_NAME"]
                        });
                    }

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
                
            }
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
