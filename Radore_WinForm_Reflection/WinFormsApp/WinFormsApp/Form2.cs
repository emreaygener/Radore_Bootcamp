using RadoreClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Matematik m = new Matematik();
            int gelenSonuc = m.Topla(Convert.ToInt32(txtSayi1.Text), Convert.ToInt32(txtSayi2.Text));
            MessageBox.Show("Toplam: "+gelenSonuc);
        }
    }
}
