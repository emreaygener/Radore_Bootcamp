namespace LogForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbLogType.SelectedItem == null || cmbLogType.SelectedItem.ToString() == "Se�iniz")
            {
                MessageBox.Show("L�tfen Log Type Se�iniz");
                return;
            }
            else if (txtDurum.Text == "")
            {
                MessageBox.Show("L�tfen Durum Giriniz");
                return;
            }
            else
            {
                string logType = cmbLogType.SelectedItem.ToString();
                string durum = txtDurum.Text;
                LogFactory logFactory = new LogFactory();
                ILogger log = logFactory.ReturnInstance(logType);
                lblSonuc.Text = log.Log(durum);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
