
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
    public partial class Form7 : Form
    {
       
        public  Label sonlabel1 = new Label();
        public Label sonlabel2 = new Label();
        public Label sonlabel3 = new Label();
        public Label sonlabel4 = new Label();
        public Label sonlabel8 = new Label();
        public Label sonlabel9 = new Label(); 
        public Label sonlabel10 = new Label();
        public Label sonlabel11 = new Label();
        public Label sonlabel12 = new Label();
        public Label sonlabel13 = new Label();
        public Label sonlabel19 = new Label();
        public Label sonlabel20 = new Label();
        public Label sonlabel21 = new Label();
        public int allahim = new int();
        DateTime bugun = DateTime.Today;
        //  System.Windows.Forms.Label btnx = new System.Windows.Forms.Label();
        public Label sonlabel22= new Label();  
        List<int> idler = new List<int>();
        List<int> dumendenID = new List<int>();
        static List<int> sayiListesi = new List<int>();
      public  List<int> UrunTutari = new List<int>();
         public List<string> kilo = new List<string>();
       public  List<string> BirimFiyat = new List<string>();
        public List<string> Urun = new List<string>();
        GirisYap f;
       public  ListBox lst = new ListBox();
        int z;
       
       //public string customerID;
        public Form7(GirisYap frr1 )
        {

            InitializeComponent();
            this.f = frr1;
            GirisYap giris = new GirisYap();
            giris.Close();

            // this.ControlBox = false;
            
            panel1.Hide();
           
            button3.Hide();
            sss.Hide();
            flowLayoutPanel2.Hide();
            //label5.Text = GirisYap.veri;
          
            flowLayoutPanel3.Visible = false;
            flowLayoutPanel4.Visible = false;
        }

        public Form7()
        {
            InitializeComponent();
            
           

        }


       


        SqlConnection baglanti = new SqlConnection("Data Source=ZUKOISREAL\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        public void Form7_Load(object sender, EventArgs e)
        {
            // customerID = label5.Text;         
            // GetCustomerInfo();
           label5.Text = f.user_name.Text; //kullanıcı adı yeri !!

           
            label6.Text = bugun.ToString("dddd, dd MMMM yyyy");
           
            // Başlangıçta butonu görünmez yapın

            flowLayoutPanel3.BringToFront();
                
                

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
                    button.Location = new System.Drawing.Point(10, 60 + (Controls.Count - 2) * 90);
                    button.Click += new EventHandler(DynamicButton_Click);
                    button.Height = 80;
                    button.Width = 130;
                    button.Font = new Font("Segoe Print", 12, FontStyle.Bold);
                   button.BackColor= System.Drawing.Color.WhiteSmoke;
                    button.Font = new Font(button.Font.FontFamily, 15);
                    flowLayoutPanel1.Controls.Add(button);
                  //kategori adını da label8 e aldık şimdi fişi oluştururken kullanıcaz.
                   


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
        string mevcutDeger;
        
        System.Windows.Forms.Button btn404 = new System.Windows.Forms.Button();
        List<float> list = new List<float>();
        readonly float toplamm;
        Dictionary<string, float> sepet = new Dictionary<string, float>();
        int eklenensayi;
        System.Windows.Forms.Button btnx2 = new System.Windows.Forms.Button();
        int counter;
        void eklebuton_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            btnx2.BackColor = Color.SeaShell;
            btnx2.Width = 50;
            btnx2.Height = 50;
            btnx2.Location = new System.Drawing.Point(100, eklenensayi * 30);

            btnx2.Text = "Sil";


            btnx2.Visible = true;
            flowLayoutPanel4.Visible = true;

            flowLayoutPanel4.Controls.Add(btnx2);
           

            button2.Show();
            button3.Show();
            btn404.Show();
            sss.Show(); 
            Panel panel2 = new Panel();
            panel2.Height = 165;
            panel2.BackColor = Color.LightSalmon;
            panel2.Font = new Font(panel2.Font.FontFamily, 12);
            panel2.Width = 266;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(panel2);
            panel2.BringToFront();
            panel2.Location = new Point(307, 323);
            panel2.Visible = true;



            btn404.Enabled = false;
            btn404.Location = new Point(479, 315);
            btn404.Width = 50;
            btn404.Height = 50;
            btn404.BackColor = Color.Bisque;

            
            panel2.Hide();
            //textbox 2 den girilen miktarı çekcez
            //btn404.Visible = true;
            {
                btnx2.Click += new EventHandler(btnx2_Click);
                pictureBox8.Visible = true;
                System.Windows.Forms.Label btnx = new System.Windows.Forms.Label();
                List<Label> btnxList = new List<Label>();
                btnx.BackColor = Color.LightYellow;
                btnx.Font = new Font(btnx.Font, FontStyle.Bold);
                btnx.Width = 100;
                btnx.Height = 20;
                
                
                btnx.Location = new System.Drawing.Point(100, eklenensayi * 40);
               
                btnx.Text = lblmik.Text + "Kg X "+ sonlabel10.Text + "TL";
                btnx.Visible = true;
                flowLayoutPanel3.Visible = true;
                System.Windows.Forms.Label btttn= btnx2.Tag as System.Windows.Forms.Label;


                btnx2.Tag = btnx;


                btnxList.Add(btnx); 
               
                eklenensayi++;
             

               
                
                flowLayoutPanel3.BringToFront();
                flowLayoutPanel4.BringToFront();
               

               sss.Items.Add("  "+mevcutDeger + "TL Tutarında  "  + label2.Text + " Eklendi!");

                sonlabel20.Text = eklenensayi.ToString();
                float a = float.Parse(mevcutDeger);
                list.Add(a);


                float toplamm = list.Sum();

                sonlabel19.Text = toplamm.ToString();



                xyz();
                void xyz()
                {

                    baglanti.Open();
                    string query = "select ID,first_name,last_name,email,password,address from KayitTablosu where email='" + label5.Text + "'";
                    SqlCommand komut = new SqlCommand(query, baglanti);

                    SqlDataReader reader = komut.ExecuteReader();

                    while (reader.Read())
                    {

                        // Verileri çekme işlemlerini burada yapabilirsiniz
                        sonlabel4.Text = reader["ID"].ToString();
                        sonlabel1.Text = reader["first_name"].ToString();
                        sonlabel2.Text = reader["last_name"].ToString();
                        sonlabel3.Text = reader["password"].ToString();
                        sonlabel21.Text = reader["address"].ToString();
                        // E-posta zaten label5.Text içerisinde

                    }


                    reader.Close();


                    // int intValue = int.Parse(sonlabel20.Text);



                    
                    //counter++;
                   // sayiListesi.Add(counter);
//  allahim = counter;


                    string query2 = "insert into FisTablosu values(@AlanID,@Alanismi,@AlanSoyisim,@Alanmail,@Alanpassword,@KategoriID,@KategoriAdi,@AlinanUrunID,@UrunName,@AlinanMiktarKg,@KalanStok,@UrunBirimFiyati,@ToplamTutar,@Date);SELECT SCOPE_IDENTITY();";
                    
                    int kategoriid = int.Parse(sonlabel13.Text);
                    int alanID = int.Parse(sonlabel4.Text);
                    int alinanurund = int.Parse(sonlabel12.Text);
                    int miktarrkg = int.Parse(lblmik.Text);
                    int stokkalan = int.Parse(sonlabel9.Text);
                    int birimfiyt = int.Parse(sonlabel10.Text);
                    int toplamtuttr = int.Parse(mevcutDeger);
                    DateTime dateD = Convert.ToDateTime(label6.Text);


                    using (SqlCommand komut2 = new SqlCommand(query2, baglanti))






                    {
                        komut2.Parameters.AddWithValue("@AlanID", alanID);
                        komut2.Parameters.AddWithValue("@Alanismi", sonlabel1.Text);
                        komut2.Parameters.AddWithValue("@AlanSoyisim", sonlabel2.Text);
                        komut2.Parameters.AddWithValue("@Alanmail", label5.Text);
                        komut2.Parameters.AddWithValue("@Alanpassword", sonlabel3.Text);
                        komut2.Parameters.AddWithValue("@KategoriID", kategoriid);
                        komut2.Parameters.AddWithValue("@KategoriAdi", sonlabel11.Text);
                        komut2.Parameters.AddWithValue("@AlinanUrunID", alinanurund);
                        komut2.Parameters.AddWithValue("@UrunName", label2.Text);
                        komut2.Parameters.AddWithValue("@AlinanMiktarKg", miktarrkg);
                        komut2.Parameters.AddWithValue("@KalanStok", stokkalan);
                        komut2.Parameters.AddWithValue("@UrunBirimFiyati", birimfiyt);
                        komut2.Parameters.AddWithValue("@ToplamTutar", toplamtuttr);
                        komut2.Parameters.AddWithValue("@Date", dateD);

                        
                        int sonEklenenID = Convert.ToInt32(komut2.ExecuteScalar());
                        idler.Add(sonEklenenID);


                        z = sonEklenenID;


                    }




                    DateTime datedD = Convert.ToDateTime(label6.Text);

                  

                    baglanti.Close();

                }
                flowLayoutPanel3.Controls.Add(btnx);
               // sss.Items.Add(btnx);
                sss.BackColor = Color.DarkSeaGreen;
                sss.ForeColor = Color.Black;
              
                UrunTutari.Add(Convert.ToInt32(mevcutDeger));               
                kilo.Add(lblmik.Text);              
                BirimFiyat.Add(sonlabel10.Text);
                Urun.Add(label2.Text);
            }

            
            
            // Diğer parametre değerlerini de güncelleyin



            //debug breakpoint yaptım burda hata veriyor neden verdiğini anlamadım.Düzelttim.
            

            baglanti.Close();

            



        }


        Label lblmik = new Label();
       
        List<string> urunadi = new List<string>();

        
        private void btnx2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            


            if (sss.SelectedIndex != -1)
            {    
                int selectedIndex = sss.SelectedIndex;
               
                // Önce ListBox'tan seçilen öğeyi kaldırın
                sss.Items.RemoveAt(selectedIndex);
               // int silinecekID = sss.SelectedIndex;
                baglanti.Open();

                //int z = idler.FindIndex(x => x == sss.SelectedIndex);

                int silinecekID = idler[selectedIndex];
                string silmeSorgusu = "DELETE FROM FisTablosu WHERE ID = @ID";

                using (SqlCommand komut = new SqlCommand(silmeSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@ID", silinecekID);
                    komut.ExecuteNonQuery();
                }
                // Ardından, aynı indekse sahip olan denetimi FlowLayoutPanel'dan kaldırın
                if (selectedIndex < flowLayoutPanel3.Controls.Count)
                {
                    flowLayoutPanel3.Controls.RemoveAt(selectedIndex);
                }

                if (selectedIndex < Urun.Count)
                {
                   
                    Urun.RemoveAt(selectedIndex);
                    kilo.RemoveAt(selectedIndex);
                    BirimFiyat.RemoveAt(selectedIndex);
                    UrunTutari.RemoveAt(selectedIndex);
                    float toplamm = list.Sum() - list[selectedIndex];                                
                    sonlabel19.Text = toplamm.ToString();//bunu yazarsam hatalı olacak.
                }


                

                baglanti.Close();

            }
           int toplamFiyat = UrunTutari.Sum();
            sonlabel19.Text = toplamFiyat.ToString();
        }

        void Dynamicbutton2_Click(object sender, EventArgs e)
        {  
            panel1.Show();
            try
            {
                System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

                if (clickedButton != null)
                {
                    string urunAdi = clickedButton.Text; // Tıklanan buton ürün adı 

                    baglanti.Open();
                    List<string>kategoriler=new List<string>();
                    List<int> kategoriIDler = new List<int>();
                    List<int> stoklar = new List<int>();
                    List<int> fiyatlar = new List<int>();
                    string query = "SELECT urunAdi,kategori,kategoriID, fiyat_kg, stok, urunID FROM URUNLER WHERE Urunadi = @urunAdi";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@urunAdi", urunAdi);
                    SqlDataReader reader = komut.ExecuteReader();
                    while (reader.Read())
                    {   string urun = Convert.ToString(reader["urunAdi"]);
                        string urunid = Convert.ToString(reader["urunID"]);
                        string kategorri  = Convert.ToString(reader["kategori"]);
                        int fiyat = Convert.ToInt32(reader["fiyat_kg"]);
                        int stok = Convert.ToInt32(reader["stok"]);
                        int kategoriID = Convert.ToInt32(reader["kategoriID"]);
                        //stok bilgisini alıp tek sorguda nasıl halledebilirim ?
                        fiyatlar.Add(fiyat);
                        stoklar.Add(stok);
                        kategoriler.Add(kategorri);
                        kategoriIDler.Add(kategoriID);
                        urunadi.Add(urun);                         
                        string urunler = urun;
                        urun = urunler.ToString();
                        label2.Text = urun;
                        sonlabel11.Text = kategorri;
                        sonlabel12.Text = urunid;
                        sonlabel13.Text =kategoriID.ToString();
                       // sss.Items.Add("Eklenen Ürün  ;"+urun);

                        // label2.Text = string.Join(", ", urunadi);
                    }
                    

                    reader.Close();

                    panel1.Controls.Clear();






                    foreach (int fiyat in fiyatlar)
                    {
                        RichTextBox RtextBoxFiyat = new RichTextBox();
                        RtextBoxFiyat.Text = fiyat.ToString();
                        RtextBoxFiyat.Height = 37;
                        RtextBoxFiyat.BackColor = Color.LightGreen;
                        RtextBoxFiyat.Font = new Font(RtextBoxFiyat.Font.FontFamily, 16);
                        RtextBoxFiyat.Width = 37;
                        RtextBoxFiyat.Font = new Font(RtextBoxFiyat.Font, FontStyle.Bold);
                        RtextBoxFiyat.ReadOnly = true;
                        RtextBoxFiyat.Location = new Point(33, 58);
                        panel1.Controls.Add(RtextBoxFiyat);


                        System.Windows.Forms.TextBox txtbx2 = new System.Windows.Forms.TextBox();
                        txtbx2.Location = new Point(18, 198); // TextBox'ın konumunu ayarlayın
                        txtbx2.Size = new Size(100, 100);
                        txtbx2.Name = "txtbx2";
                        txtbx2.BackColor = Color.LightGreen;
                        txtbx2.Enter += new EventHandler(txtbx2_Enter);
                        panel1.Controls.Add(txtbx2);
                        panel1.Controls.Add(eklebuton);
                        Label lbl = new Label();
                        lbl.Size = new Size(84, 16);
                        lbl.BackColor = Color.DarkSeaGreen;
                        lbl.Location = new Point(15, 160);
                        lbl.Font = new Font("Segoe Print", 7, FontStyle.Bold);
                        lbl.Text = "Girilen Miktar";
                        panel1.Controls.Add(lbl);

                        void txtbx2_Enter(object sender3, EventArgs e3)
                        {
                            // TextBox'a odaklandığında, varsayılan metni temizleyin ve metin rengini siyah yapın
                            if (txtbx2.Text == "")
                            {    //.hint();
                                txtbx2.Text = "Kg";
                                txtbx2.ForeColor = SystemColors.WindowText; // Metin rengini siyah yapın

                            }

                        }

                        void txtbx2_Leave(object sender4, EventArgs e4)
                        {
                            // TextBox'tan çıkıldığında, eğer metin boşsa varsayılan metni geri ekleyin ve metin rengini gri yapın
                            if (string.IsNullOrWhiteSpace(txtbx2.Text))
                            {
                                txtbx2.Text = "Kilogram miktarını girin";
                                txtbx2.ForeColor = SystemColors.GrayText; // Metin rengini gri yapın
                            }
                        }
                       
                        // string mevcutDeger = "";
                        // Kullanıcının miktarı 

                        foreach (int stok in stoklar)
                        {

                            txtbx2.TextChanged += (sender2, e2) =>
                            {
                               // this.eklebuton.Click += new System.EventHandler(this.eklebuton_Click);
                                System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender2;
                                RichTextBox rTextBoxFiyat = (RichTextBox)panel1.Controls[panel1.Controls.IndexOf(textBox) - 1];
                                Label miktarlabel = new Label();
                                
                                if (!float.TryParse(textBox.Text, out float miktar) || !string.IsNullOrEmpty(textBox.Text))
                                {

                                    if (miktar > stok)
                                    {

                                        MessageBox.Show("Üzgünüz Stoğumuzda istenilen miktarda ürün kalmamıştır.İstediğiniz ürünün şu anki stok miktarı   ;" + stok);


                                    }

                                    else
                                    {




                                        float kalan = stok - miktar;
                                        float Toplam = miktar * fiyat;
                                        float mvcdqr = Toplam;
                                     
                                        mevcutDeger = Toplam.ToString();                                      
                                        rTextBoxFiyat.Text = mevcutDeger;

                                        
                                        string mik = miktar.ToString();
                                        sonlabel9.Text = kalan.ToString();
                                        lblmik.Text = mik;
                                        btn404.Text = mik;
                                        sonlabel10.Text =fiyat.ToString();
                                        // miktarlabel.Text =Convert.ToString(miktar);
                                        label8.Text = miktar.ToString()+" Kilogram Fiyatı";

                                        baglanti.Open();
                                        

                                        string updateQuery = "UPDATE URUNLER SET Stok = @kalan WHERE urunAdi = @urunAdi";
                                        SqlCommand updateKomut = new SqlCommand(updateQuery, baglanti);
                                        updateKomut.Parameters.AddWithValue("@kalan", kalan);
                                        updateKomut.Parameters.AddWithValue("@urunAdi", urunAdi);

                                        int affectedRows = updateKomut.ExecuteNonQuery();

                                    }



                                }

                                else
                                {
                                    // Kullanıcı boş bir değer girdiyse mevcut değeri sıfırla
                                    mevcutDeger = "0";
                                    rTextBoxFiyat.Text = mevcutDeger;



                                }


                                baglanti.Close();


                            };


                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally { baglanti.Close(); }

        }

        void DynamicButton_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            try
            {
                // Seçilen butonun metnini alın
                System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
                if (clickedButton != null)
                {
                    string kat = clickedButton.Text;

                    baglanti.Open();
                    List<string> veriler = new List<string>();
                    string query = "SELECT U.UrunAdi AS Urun FROM Kategoriler K INNER JOIN URUNLER U ON K.Kategoriid = U.kategoriID WHERE K.KategoriAdi = @kat";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@kat", kat);
                    SqlDataReader reader = komut.ExecuteReader();
                    
                  
                    while (reader.Read())
                    {
                        string veri = reader["Urun"].ToString();
                        
                        veriler.Add(veri);
                        


                    }

                   


                    // Dinamik butonları oluştu
                    flowLayoutPanel2.Controls.Clear();
                    for (int i = 0; i < veriler.Count; i++)
                    {
                        System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                        btn.Text = veriler[i];
                        btn.Name = "btn" + veriler[i];
                        btn.Location = new System.Drawing.Point(100, i * 30);
                        btn.Height = 50;
                        btn.Width = 150;
                        btn.Font = new Font("Segoe Print",13, FontStyle.Bold);
                        btn.Font = new Font(btn.Font.FontFamily, 13);
                        btn.AutoSize = true;
                        // btn.Anchor = AnchorStyles.None;
                        // btn.Margin = new Padding((flowLayoutPanel1.Width - button1.Width) / 60, 0, 4, 10);
                        btn.BackColor = Color.LightGreen;
                        flowLayoutPanel2.Controls.Add(btn);
                        
                        int controlWidth = btn.Width; // Kontrolün genişliği
                        int controlHeight = btn.Height; // Kontrolün yüksekliği

                        int x = controlWidth / 2; // X koordinatı
                        int y = controlHeight / 2; // Y koordinatı
                        btn.Location = new System.Drawing.Point(20, 40 + (Controls.Count - 2) * 30);
                        // btn.Location = new Point(x, y);

                        
                        btn.Click += new EventHandler(Dynamicbutton2_Click);

                       

                    }

                }

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form7_Load_1(object sender, EventArgs e)
        {




        }


        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            flowLayoutPanel2.AutoScroll = true;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Çıkışınız yapıldı,teşekkür ederiz");
            

           






            this.Close();


        }




        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GirisYap grkapat = new GirisYap();
            grkapat.Close();

            flowLayoutPanel2.Hide();
            panel1.Hide();
            CreateButtons();
            pictureBox1.Dispose();
             label9.Dispose();
            label3.Dispose();
            //label1.Dispose();
            //pictureBox5.Dispose();
            flowLayoutPanel2.Show();

            // İşlem tamamlandı, bayrağı true olarak ayarla          
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        void panelolustur()
        {


        }
       // Label lblMevcutDeger = new Label();
       


        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            label8.BringToFront();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void panel2_Paint_2(object sender, PaintEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            // Her bir öğe üzerinde döngüyü çalıştırın
            

            

            if (sss.Items.Count == 0)
            { MessageBox.Show("Zaten Sepetin boş."); }
            else
            {
                baglanti.Open();
                int aa = Convert.ToInt32(sonlabel19.Text);
                string query3 = "insert into Fisler values(@KullaniciUsername,@kullaniciID,@ToplamTutar,@date2)";
                SqlCommand komut3 = new SqlCommand(query3, baglanti);
                komut3.Parameters.AddWithValue("@KullaniciUsername", label5.Text);
                komut3.Parameters.AddWithValue("@kullaniciID", sonlabel4.Text);
                komut3.Parameters.AddWithValue("@ToplamTutar", aa);
                komut3.Parameters.AddWithValue("@date2", bugun);
                komut3.ExecuteNonQuery();

                baglanti.Close();
                if (MessageBox.Show("Sipariş tamamlandı. Teşekkür ederiz.", "Bilgi", MessageBoxButtons.OK) == DialogResult.OK)
                {
                   /* string idcekme = "SELECT ID FROM Fisler";
                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand(idcekme, baglanti);
                    int sonEklenenID = Convert.ToInt32(komut3.ExecuteScalar());
                    baglanti.Close();

                    // Güncelleme işlemi
                    if (sonEklenenID > 0)
                    {
                        baglanti.Open();
                        string updateSorgusu = "UPDATE Fisler SET ToplamTutar = @ToplamTutar WHERE ID = @ID";
                        using (SqlCommand komut = new SqlCommand(updateSorgusu, baglanti))
                        {
                            komut.Parameters.AddWithValue("@ToplamTutar", toplamm);
                            komut.Parameters.AddWithValue("@ID", sonEklenenID); // Son eklenen alışveriş fişinin ID'sini kullan
                            komut.ExecuteNonQuery();
                        }
                        baglanti.Close();
                    }
                   */
                    for (int i = 0; i < sss.Items.Count; i++)
                    {


                        lst.Items.Add(sss);
                        lst.Visible = false;
                        sss.Items.Clear();
                        flowLayoutPanel3.Controls.Clear();

                        flowLayoutPanel4.Controls.Clear();


                    }
               
                
                fis fs = new fis(this);
                fs.ShowDialog();
               
                //this.Close();
                    
                }

            }
            //sss.Items.Clear();
           // flowLayoutPanel3.Controls.Clear();
           
        }

        private void sss_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sss.Items.Count == 0) { MessageBox.Show("sepet zaten boş"); }
            DialogResult secenek= MessageBox.Show("Sepeti Temizlemek istediğinizden emin misiniz ?","Temizle", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {   for(int i =0; i<eklenensayi; i++) { 

                    baglanti.Open();

                      
                    
                        
                     //   string silme2 = "DELETE FROM Fisler WHERE ID = (SELECT MAX(ID) FROM Fisler)";
                    string silmeSorgusu = "DELETE FROM FisTablosu WHERE ID = (SELECT MAX(ID) FROM FisTablosu)";
                    using (SqlCommand komut1 = new SqlCommand(silmeSorgusu, baglanti))
                    {
                        komut1.ExecuteNonQuery();
                    }

                       
                     //  using (SqlCommand komut2 = new SqlCommand(silme2, baglanti))
                       // {
                       //     komut2.ExecuteNonQuery();
                      //  }

                        baglanti.Close();
                    }
                    flowLayoutPanel3.Controls.Clear();
                    flowLayoutPanel4.Controls.Clear();
                    sss.Items.Clear();
                }
            flowLayoutPanel3.Controls.Clear(); // Sepet UI'sını temizle
            sss.Items.Clear(); // Sepet listesini temizle
            Urun.Clear(); // Ürün listesini temizle
            kilo.Clear(); // Kilo listesini temizle
            BirimFiyat.Clear(); // Birim fiyat listesini temizle
            UrunTutari.Clear(); // Ürün tutarı listesini temizle
            list.Clear(); // Fiyat listesini temizle
            idler.Clear();
            sonlabel19.Text = "0";
            //seçili indexteki id ye göre işlemi sil.
            // Son eklenen alışveriş fişinin ID'sini al
           
            baglanti.Close();





        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        { 
            Gecmis past = new Gecmis();
            past.Show();
        }
    } 




}