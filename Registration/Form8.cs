
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.WebSockets;
using System.Reflection;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Registration
{
    public partial class Gecmis : Form
    {


        public static Label label77 = new Label();
        public Gecmis()
        {
            
            InitializeComponent();

            abc();

        }
        SqlConnection baglanti = new SqlConnection("Data Source=ZUKOISREAL\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
       void abc()
        {
            
            baglanti.Open();
            string query = "Select KategoriAdi,UrunName,AlinanMiktarKg,UrunBirimFiyati,ToplamTutar,Date From FisTablosu where Alanmail='" + label77.Text + "'";
            SqlCommand komut = new SqlCommand(query, baglanti);

            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                // Verileri çekme işlemlerini burada yapabilirsiniz
                string b = reader["KategoriAdi"].ToString();
                string c = reader["UrunName"].ToString();
                string d = reader["AlinanMiktarKg"].ToString();
               string e = reader["UrunBirimFiyati"].ToString();
                string f = reader["ToplamTutar"].ToString();
                string g = reader["Date"].ToString();

                listView1.Items.Add(b);
                listView1.Items.Add(c);
                listView1.Items.Add(d);
                listView1.Items.Add(e);
                listView1.Items.Add(f);
                listView1.Items.Add(g);


            }


            reader.Close();
            baglanti.Close();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Gecmis_Load(object sender, EventArgs e)
        {

           label77.Text= GirisYap.lbbl.ToString();


        }
    }
}
