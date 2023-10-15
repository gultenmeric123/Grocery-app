using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Schema;

namespace Registration
{
    public partial class GirisYap : Form
    {
        public static Label lbbl = new Label();

        public GirisYap()
        {
            InitializeComponent();

            // Form1 (veri girişi yapan form)


            // Form2 (veriyi alan form)


            // Form1 (veri girişi yapan form)
            //veri = user_name.Text;
            //Form7 form7 = new Form7();
            // form7.ToString();

          
           Gecmis gg = new Gecmis();
            gg.Close();

        }
        SqlConnection baglanti = new SqlConnection("Data Source=ZUKOISREAL\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
       
        public void button1_Click(object sender, EventArgs e)
        {
                 
            
            if (user_name.Text!=" " && password.Text!=" ")
            {
                string query = "select count(*) from KayitTablosu where email='" + user_name.Text + "' and password= '" + password.Text + "'";
                
                

                string query2 = "insert into KayitTablosu values(@UserName)";
                SqlCommand komut2 = new SqlCommand(query2, baglanti);
                komut2.Parameters.AddWithValue("@UserName", user_name.Text);
                //username bölümünü kullanıcı adından aldığımız mail olarak atayacak
                baglanti.Open();
                SqlCommand komut = new SqlCommand(query, baglanti);
                int x=(int)komut.ExecuteScalar();
                if (x != 1)
                {
                    MessageBox.Show("hatalı giriş yaptınız.","Hata",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                    baglanti.Close();
                    user_name.Clear();
                    password.Clear();
                }
                else
                {
                    MessageBox.Show("Hoşgeldiniz,Alışverişe başlayabilirsiniz.", "G -MARKET", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    baglanti.Close();
                    lbbl.Text = user_name.Text;

                    Form7 fr7 = new Form7(this);
                    fr7.ShowDialog();


                    user_name.Clear();
                    password.Clear();



                    


                }


                this.Close();

            }
            else
            {
                MessageBox.Show("boşlukları doldurduğunuzdan emin olun.","HATA",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        private void check_pass_CheckedChanged(object sender, EventArgs e)
        {
            
            
            
            
            
            if (check_pass.Checked)
            {
                password.UseSystemPasswordChar = false;
              
                //Yani beni hatırla butonuna check atılırsa girilen şifre kaydedilir.Bunu hepsine bile uygulayabiliriz çünkü properties kısmından ayarlanıyor.
            }
            else
            {
                password.UseSystemPasswordChar = true;
               
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frx = new Form1();
            frx.Show();
            this.Hide();
            
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void user_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
