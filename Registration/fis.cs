using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class fis : Form
    {
        Form7 fx;
        Label label89=new Label();
        public fis(Form7 frx)
        {
            InitializeComponent();
            this.fx = frx;
            

            Form7 fr = new Form7(); 
            fr.Close();
            DateTime bugun = DateTime.Today;

           label89.Text = bugun.ToString("dddd, dd MMMM yyyy");

        }


        SqlConnection baglanti = new SqlConnection("Data Source=ZUKOISREAL\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        private void TemizleVeKapat()
        {
            foreach (Control yenilabel in flowLayoutPanel4.Controls)
            {
                if (yenilabel is Label)
                {
                    flowLayoutPanel4.Controls.Remove(yenilabel);
                    yenilabel.Dispose();
                }
            }

            foreach (Control yenilabel in flowLayoutPanel2.Controls)
            {
                if (yenilabel is Label)
                {
                    flowLayoutPanel2.Controls.Remove(yenilabel);
                    yenilabel.Dispose();
                }
            }

            foreach (Control yenilabel in flowLayoutPanel3.Controls)
            {
                if (yenilabel is Label)
                {
                    flowLayoutPanel3.Controls.Remove(yenilabel);
                    yenilabel.Dispose();
                }
            }

            foreach (Control yenilabel in flowLayoutPanel5.Controls)
            {
                if (yenilabel is Label)
                {
                    flowLayoutPanel5.Controls.Remove(yenilabel);
                    yenilabel.Dispose();
                }
            }

            label16.Controls.Clear();
            this.Close();
        }

        

        // ... Diğer kodlar ...


        private void button1_Click(object sender, EventArgs e)
        {
            TemizleVeKapat();

        }

        private void fis_Load(object sender, EventArgs e)
        {   
            kulAdi.Text = fx.label5.Text;
            Kuladsoyad.Text=fx.sonlabel1.Text+" "+ fx.sonlabel2.Text;
            Kuladres.Text = fx.sonlabel21.Text;
            tarih.Text = label89.Text;
            
            label16.Text=fx.sonlabel19.Text+" TL";


            foreach (string veri in fx.Urun)
            {
                // Yeni bir Label oluşturun ve özelliklerini ayarlayın.
                Label yeniLabel = new Label();
                yeniLabel.Text = veri;
                yeniLabel.AutoSize = true; // Otomatik boyutlandırma
                yeniLabel.Location = new System.Drawing.Point(20, 20); // Label'ın konumu

                // Oluşturulan Label'ı form üzerine ekleyin.
                flowLayoutPanel4.Controls.Add(yeniLabel);              
                int aralik = 30;
                yeniLabel.Location = new System.Drawing.Point(20, yeniLabel.Location.Y + aralik);
            }


            foreach (int veri in fx.UrunTutari)
            {
                // Yeni bir Label oluşturun ve özelliklerini ayarlayın.
                Label yeniLabel = new Label();
                yeniLabel.Text = veri.ToString();
                yeniLabel.AutoSize = true; // Otomatik boyutlandırma
                yeniLabel.Location = new System.Drawing.Point(20, 20); // Label'ın konumu

                // Oluşturulan Label'ı form üzerine ekleyin.
                flowLayoutPanel2.Controls.Add(yeniLabel);
                int aralik = 30;
                yeniLabel.Location = new System.Drawing.Point(20, yeniLabel.Location.Y + aralik);
            }

            foreach (string veri in fx.BirimFiyat)
            {
                // Yeni bir Label oluşturun ve özelliklerini ayarlayın.
                Label yeniLabel = new Label();
                yeniLabel.Text = veri;
                yeniLabel.AutoSize = true; // Otomatik boyutlandırma
                yeniLabel.Location = new System.Drawing.Point(20, 20); // Label'ın konumu

                // Oluşturulan Label'ı form üzerine ekleyin.
                flowLayoutPanel3.Controls.Add(yeniLabel);
                int aralik = 30;
                yeniLabel.Location = new System.Drawing.Point(20, yeniLabel.Location.Y + aralik);
            }

            foreach (string veri in fx.kilo)
            {
                // Yeni bir Label oluşturun ve özelliklerini ayarlayın.
                Label yeniLabel = new Label();
                yeniLabel.Text = veri;
                yeniLabel.AutoSize = true; // Otomatik boyutlandırma
                yeniLabel.Location = new System.Drawing.Point(20, 20); // Label'ın konumu

                // Oluşturulan Label'ı form üzerine ekleyin.
                flowLayoutPanel5.Controls.Add(yeniLabel);
                int aralik = 30;
                yeniLabel.Location = new System.Drawing.Point(20, yeniLabel.Location.Y + aralik);
            }


            baglanti.Open();
            string query = "Select*from GondericiBilgileri";
            SqlCommand komut = new SqlCommand(query, baglanti);

            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {

                // Verileri çekme işlemlerini burada yapabilirsiniz
               
                gondericiNo.Text = reader["GondericiNo"].ToString();
                GondericiName.Text = reader["GondericiIsmi"].ToString();
                GondericiAdres.Text = reader["GondericiAdres"].ToString();
                

            }


            reader.Close();



            baglanti.Close();



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { 
            Kuladres.Hide();
            }
            else { Kuladres.Show(); }
        }

        private void lstbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Kuladres_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
