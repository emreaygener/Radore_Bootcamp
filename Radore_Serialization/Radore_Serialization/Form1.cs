using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Radore_Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                Name = txtAd.Text,
                Phone = txtTelefon.Text,
                DateOfBirth = dtpDOB.Value,
                Department = txtDepartman.Text,
                Salary = Convert.ToInt32(txtMaas.Text),
                AdditionalInfo = "Serileştirme olmayacak alan"
            };

            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            FileStream fsout = new FileStream("Employee.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fsout)
                {
                    xs.Serialize(fsout, emp);
                    txtMaas.Text = "";
                    txtAd.Text = "";
                    txtDepartman.Text = "";
                    txtTelefon.Text = "";
                    dtpDOB.Value = DateTime.Now;
                    MessageBox.Show("Serileştirme işlemi başarılı");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }

        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            FileStream fsin = new FileStream("Employee.xml", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    emp = (Employee)xs.Deserialize(fsin);
                    txtMaas.Text = emp.Salary.ToString();
                    txtAd.Text = emp.Name;
                    txtDepartman.Text = emp.Department;
                    txtTelefon.Text = emp.Phone;
                    dtpDOB.Value = emp.DateOfBirth;
                    MessageBox.Show("Deserileştirme işlemi başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnJsonSerialize_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = "Product 1";
            product.ExpireDate = DateTime.Now;
            product.Price = 100;
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Emre Aygener\Desktop\RadoreBootcamp\Radore_Serialization\Radore_Serialization\Product.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, product);
                MessageBox.Show("Json serileştirme işlemi başarılı");
            }
        }

        private void btnJsonDeserialize_Click(object sender, EventArgs e)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader file = File.OpenText(@"C:\Users\Emre Aygener\Desktop\RadoreBootcamp\Radore_Serialization\Radore_Serialization\Product.json"))
            using (JsonReader reader = new JsonTextReader(file))
            {
                Product okunanProduct = (Product)serializer.Deserialize(reader, typeof(Product));
                MessageBox.Show("Ürün adı: " + okunanProduct.Name + " fiyatı: " + okunanProduct.Price.ToString() + " Son kullanma tarihi: " + okunanProduct.ExpireDate.ToString());
            }
        }
    }
}

