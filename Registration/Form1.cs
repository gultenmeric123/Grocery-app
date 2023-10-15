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
using System.Linq.Expressions;
using System.Drawing.Text;

namespace Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ZUKOISREAL\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if(first_name.Text!=""&& last_name.Text!=""&& dateTimePicker1.Text!=""&& gender.Text!=""&& adres.Text!=""&& email.Text!="" && password.Text!="" && con_pass.Text!="")
                {
                    if(password.Text== con_pass.Text)
                    {
                        int x = kontrol(email.Text);
                        if (x != 1)
                        {
                            baglanti.Open();
                            SqlCommand command = new SqlCommand("insert into KayitTablosu values(@first_name,@last_name,@birth_date,@gender,@address,@email,@password)",baglanti);
                            
                            command.Parameters.AddWithValue("@first_name", first_name.Text);
                            command.Parameters.AddWithValue("@last_name", last_name.Text);
                            command.Parameters.AddWithValue("@birth_date",Convert.ToDateTime(dateTimePicker1.Text));
                            command.Parameters.AddWithValue("@gender",gender.Text);
                            command.Parameters.AddWithValue("@address", adres.Text);
                            command.Parameters.AddWithValue("@email", email.Text); //eğer mail aynı ise zaten kayıtlısınız demeli.
                            command.Parameters.AddWithValue("@password", password.Text);
                            command.ExecuteNonQuery();   //debug breakpoint yaptım burda hata veriyor neden verdiğini anlamadım.Düzelttim.
                            baglanti.Close();
                            MessageBox.Show("Kaydınız Oluşturuldu.");
                            this.Close();
                            GirisYap fr2 = new GirisYap();
                            fr2.ShowDialog();
                            first_name.Text = "";
                            last_name.Text = "";
                            gender.Text = "";
                            email.Text = "";
                            password.Text = "";
                            con_pass.Text = "";
                            Form1 form = new Form1();
                            form.Close();


                        }
                        else
                        {
                            MessageBox.Show("Zaten Kayıtlısınız.");
                        }
                    }
                    else
                    {

                        MessageBox.Show("Yanlış password!","Uyarı",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    }

                }

                else
                {
                    MessageBox.Show("boşlukları doldurdunuz mu?","Geri Dön",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
               }
                            
             }
            catch(Exception ex) {

                MessageBox.Show(ex.Message); //Hata mesajı neyse onu gösterir.

            }
            
            
            

            int kontrol(string email)
            {
                baglanti.Open();
                string query = "select count (*) from KayitTablosu where email= '" + email + "'";
                SqlCommand command = new SqlCommand(query, baglanti); //exec.sclr tek bir değer döndürmek için kullanılır.Mesela tüm satırları toplayıp -count- yazar veya ilk satırın ilk sütununu yazar.
                int x=(int)command.ExecuteScalar();  //burayı başka yerden aldım sanırım farklı bir fonk oluşturma yöntemi.
                //Yani bu fonk kayıt tablosundaki istenilen where komutunda kaç tane kayıt varsa onları toplayıp ilk baştaki hücreye atar.Bu da row1,Coulmn1.
                baglanti.Close();
                return x; //void olmayan bir fonk yazdık ve count isleminde x e atanan değeri return ettik.
            }
            
        }

        private void check_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pass.Checked)
            {
                password.UseSystemPasswordChar = false;
                con_pass.UseSystemPasswordChar = false;
                //Yani check atılırsa girilen şifre kaydedilir.Bunu hepsine bile uygulayabiliriz çünkü properties kısmından ayarlanıyor.
            }
            else
            {
                password.UseSystemPasswordChar = true;
                con_pass.UseSystemPasswordChar = true;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //buna tıklayınca beni üye ol sayfasına atmalı.
          GirisYap fr2= new GirisYap();
            fr2.ShowDialog();
            Form1 form = new Form1();
            form.Hide();

        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;   //karakterleri gizledik.
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void first_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
