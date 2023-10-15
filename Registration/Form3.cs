using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Registration
{

    public partial class Form3 : Form
    {  
        public Form3()
        {
            InitializeComponent();
           
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ZUKOISREAL\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'girisDbDataSet2.Kategoriler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           // this.kategorilerTableAdapter1.Fill(this.girisDbDataSet2.Kategoriler);
            // TODO: Bu kod satırı 'girisDbDataSet1.URUNLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           // this.uRUNLERTableAdapter.Fill(this.girisDbDataSet1.URUNLER);
            // TODO: Bu kod satırı 'girisDbDataSet.KayitTablosu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           // this.kayitTablosuTableAdapter.Fill(this.girisDbDataSet.KayitTablosu);
           // string query = "select kategori, urunAdi, fiyat_kg from URUNLER";
           // cmd.Connection = baglanti;  
           // cmd.CommandText=query.ToLower();
         //   baglanti.Open();
          //  adapter.SelectCommand = cmd;
           // adapter.Fill(dt);
           // dataGridView1.DataSource = dt;
          // dataGridView1.Refresh();    
          SqlCommand komut =new SqlCommand("Select*from Kategoriler",baglanti);
            SqlDataReader dtr;
            baglanti.Open();
            dtr= komut.ExecuteReader();
            while (dtr.Read())
            {
                comboBox1.Items.Add(dtr["KategoriAdi"]);

            }
            baglanti.Close();
            if (comboBox1.Items.Count > 1)
            {
                comboBox1.SelectedIndex = -1; //combobox ın ıçıni ilk etapta açtığmızda boş görmeliyiz.
            }
            doldur();
        }
        private void doldur()
        {
            SqlCommand komut2 = new SqlCommand("Select urunAdi,fiyat_kg,kategori from URUNLER where kategori='" + comboBox1.Text + "'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            da.SelectCommand = komut2;
            dataTable.Clear();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (System.Exception ex)
            {
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            doldur();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
               
           
        }

        private void targetdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
                // Sadece artırma veya azaltma düğmelerine tıklanırsa işlem yap.
                // Satır indexi sıfırdan büyük eşitse veya sütun indeksi artı yazan kolona eşit ya da eksi yazan kolona eşitse;
                if (e.RowIndex >= 0 && (e.ColumnIndex == targetdataGridView.Columns["Arti"].Index || e.ColumnIndex == targetdataGridView.Columns["Eksi"].Index))
                {
                    // eğer artı yazan butona tıklandıysa;
                    if (e.ColumnIndex == targetdataGridView.Columns["Arti"].Index)
                    {
                        // Artırma düğmesiyle miktarı artırıyoruz.
                        DataGridViewCell cell = targetdataGridView.Rows[e.RowIndex].Cells["Miktar"];
                        int miktar = Convert.ToInt32(cell.Value);
                        miktar++;
                        cell.Value = miktar;
                    }
                    else if (e.ColumnIndex == targetdataGridView.Columns["Eksi"].Index)
                    {
                        // Azaltma düğmesine tıklanırsa miktarı azalt (minimum sınırı kontrol et)
                        DataGridViewCell cell = targetdataGridView.Rows[e.RowIndex].Cells["Miktar"];
                        int miktar = Convert.ToInt32(cell.Value); //şimdi içindeki value tipinde olduğundan inte çeviriyoruz.
                        if (miktar > 0)//burda aslında sınır koyulabilir ancak şimdilik kalsın.
                                       //Diyor ki miktar hücresini 0 olana kadar azalt ve hücredeki değeri miktar olarak ata.

                        {
                            miktar--;
                            cell.Value = miktar;
                        }
                    }
                }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("urunAdi");
            dt.Columns.Add("fiyat_kg"); //dt nesnesine datagridviewdeki kolonların,kullanmak istediklerimizi ekliyoruz.
            foreach (DataGridViewRow row in dataGridView1.Rows) //burası klasik dizideki foreach kullanımı.İşimize foreach yaradı belki while ile yapılabilirdi .
            //foreach ile dgview1 satırlarının her birini işaretli mi değil mi kontrol edebilmek için,
            //satırlardaki tüm check butonlarının değerlerini boola çeviriyoruz ki if ile kontrol edebilelim.Zaten iki olasılığımız var.true false kullanmak mantıklı oldu.
            //
            {
                bool sec = Convert.ToBoolean(row.Cells["Check"].Value);
                if (sec)// ifle kontrol edebilmek için check hücresinin değerini boola çevirdik.
                    //yani sonuç olarak  işaretliyse dgv den alıp tdgv e atacak.
                    //AMA SADECE KOLONA EKLEDİĞİMİZ VERİLER OLACAK YANİ KATEGORİ SÜTUNU VE KATEGORİ ID Sİ OLMAYACAK.
                {
                    dt.Rows.Add(row.Cells[1].Value, row.Cells[2].Value);
                    targetdataGridView.DataSource = dt;
                    //dt nesnemde sakladığım verileri de ttgve atmak için datasource metodunu kullanıoruz.B u şekilde seçili hücre kalmayana kadar devam ediyor.
                }
               

            }


        }

    }
}
