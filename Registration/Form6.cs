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
    public partial class Form6 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ZUKOISREAL\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private void Form6_Load(object sender, EventArgs e)
        {


        }


        public Form6()
        {
            InitializeComponent();
        }




    }
}

