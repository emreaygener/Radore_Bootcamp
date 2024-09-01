using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinFormsApp
{
    public class ClassFactory
    {
        public void CreateClass(string className)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RadoreDb;Integrated Security=SSPI;";
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = $"SELECT DISPLAY_NAME FROM OdemeTipleri WHERE CLASS_NAME = \'{className}\'";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string displayName = reader["DISPLAY_NAME"].ToString();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("using System;");
                sb.AppendLine("namespace WinFormsApp");
                sb.AppendLine("{");
                sb.AppendLine($"    public class {className} : IOdemeTipi");
                sb.AppendLine("    {");
                sb.AppendLine("        public string ode(double tutar)");
                sb.AppendLine("        {");
                sb.AppendLine($"            return \"{displayName} ile \" + tutar + \" tl ödeme alınmıştır\";");
                sb.AppendLine("        }");
                sb.AppendLine("    }");
                sb.AppendLine("}");
                File.WriteAllText($@"..\..\..\{className}.cs", sb.ToString());
            }
        }
    }
}
