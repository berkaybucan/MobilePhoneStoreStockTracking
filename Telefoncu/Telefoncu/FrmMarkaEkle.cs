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

namespace Telefoncu
{
    public partial class FrmMarkaEkle : Form
    {
        public FrmMarkaEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2C6E5LJ;Initial Catalog=DbTelefoncu;Integrated Security=True");

        private void FrmMarkaEkle_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMARKA (MARKA) values (@P1)",baglanti);
            komut.Parameters.AddWithValue("@P1", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni Marka Başarıyla Eklenmiştir");
        }
    }
}
