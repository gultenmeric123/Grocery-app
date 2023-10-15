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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq.Expressions;
using System.Collections;
using Registration.GirisDbDataSet1TableAdapters;

namespace Registration
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ZUKOISREAL\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Form4_Load(object sender, EventArgs e)
        {


            CreateButtons();

        }

        private void CreateButtons()
        {
            try
            {
                baglanti.Open();
                string query = "SELECT * FROM Kategoriler";
                SqlCommand komut = new SqlCommand(query, baglanti);
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    string data = reader["KategoriAdi"].ToString();
                    System.Windows.Forms.Button button = new System.Windows.Forms.Button();
                    button.Text = data;
                    button.Name = "btn" + data;
                    button.Location = new System.Drawing.Point(20, 40 + (Controls.Count - 2) * 30);
                    button.Click += new EventHandler(DynamicButton_Click);

                    flowLayoutPanel2.Controls.Add(button);



                }
                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
       
        void DynamicButton_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                string query = "SELECT K.KategoriAdi AS Adi, U.UrunAdi AS Urun FROM Kategoriler K INNER JOIN URUNLER U ON K.Kategoriid=U.kategoriID WHERE K.KategoriAdi=@kat ";

                SqlCommand komut = new SqlCommand(query, baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                List<string> veriler = new List<string>();

                string kat = reader["KategoriAdi"].ToString();
                if (kat == "Meyve")
                {
                    while (reader.Read())
                    {
                        string[] veriDizisi = veriler.ToArray();
                        string veri = reader["Urun"].ToString();
                        veriler.Add(veri);
                        for (int i = 1; i < veriDizisi.Length; i++)
                        {
                            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();

                            //Point sınıfından nesne türetip, X ve Y koordinatlarının değerlerini verdim.
                            Point konum = new Point(100, i * 30);

                            //X ve Y koordinatlarını butona aktardım.
                            btn.Location = konum;

                            //Butona ilişkin diğer özelliklerimi atadım.
                            btn.Text = veriDizisi.Length.ToString();
                            btn.Height = 30;
                            btn.Width = 30;
                            btn.Font = new Font(btn.Font.FontFamily, 6);

                            //Butonu forma ekledim.
                            this.Controls.Add(btn);
                            veriler.Add(btn.ToString());
                        }



                    }





                }
                else if (kat == "Sebze")
                {
                    while (reader.Read())
                    {
                        string[] veriDizisi = veriler.ToArray();
                        string veri = reader["Urun"].ToString();
                        veriler.Add(veri);
                        for (int i = 1; i < veriDizisi.Length; i++)
                        {
                            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();


                            Point konum = new Point(100, i * 30);


                            btn.Location = konum;


                            btn.Text = veriDizisi.Length.ToString();
                            btn.Height = 30;
                            btn.Width = 30;
                            btn.Font = new Font(btn.Font.FontFamily, 6);


                            this.Controls.Add(btn);
                            veriler.Add(btn.ToString());
                        }

                    }
                }
                else if (kat == "Baklagil")
                {
                    while (reader.Read())
                    {
                        string[] veriDizisi = veriler.ToArray();
                        string veri = reader["Urun"].ToString();
                        veriler.Add(veri);
                        for (int i = 1; i < veriDizisi.Length; i++)
                        {
                            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();


                            Point konum = new Point(100, i * 30);


                            btn.Location = konum;


                            btn.Text = veriDizisi.Length.ToString();
                            btn.Height = 30;
                            btn.Width = 30;
                            btn.Font = new Font(btn.Font.FontFamily, 6);


                            this.Controls.Add(btn);
                            veriler.Add(btn.ToString());
                        }

                    }
                }
                else if (kat == "Kuruyemis")
                {
                    while (reader.Read())
                    {
                        string[] veriDizisi = veriler.ToArray();
                        string veri = reader["Urun"].ToString();
                        veriler.Add(veri);
                        for (int i = 1; i < veriDizisi.Length; i++)
                        {
                            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();


                            Point konum = new Point(100, i * 30);


                            btn.Location = konum;


                            btn.Text = veriDizisi.Length.ToString();
                            btn.Height = 30;
                            btn.Width = 30;
                            btn.Font = new Font(btn.Font.FontFamily, 6);


                            this.Controls.Add(btn);
                            veriler.Add(btn.ToString());
                        }

                    }
                }
                else if (kat == "Ekmek")
                {
                    while (reader.Read())
                    {
                        string[] veriDizisi = veriler.ToArray();
                        string veri = reader["Urun"].ToString();
                        veriler.Add(veri);
                        for (int i = 1; i < veriDizisi.Length; i++)
                        {
                            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                            Point konum = new Point(100, i * 30);
                            btn.Location = konum;
                            btn.Text = veriDizisi.Length.ToString();
                            btn.Height = 30;
                            btn.Width = 30;
                            btn.Font = new Font(btn.Font.FontFamily, 6);
                            this.Controls.Add(btn);
                            veriler.Add(btn.ToString());
                        }

                    }
                }

                /*  while (reader.Read())
                  {                      
                          string veri = reader["Urun"].ToString();
                      veriler.Add(veri);  

                  }*/
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: ");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                panel1.Controls.Clear();     // Yeni dinamik butonları oluşturun

                baglanti.Close();
                CreateButtons();

            }

        }
    } 
}

       


        
    

