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
    public partial class FrmAksesuarEkle : Form
    {
        public FrmAksesuarEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2C6E5LJ;Initial Catalog=DbTelefoncu;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLAKSESUAR (AKSESUARAD,AKSESUARALISFIYAT,AKSESUARSATISFIYAT,AKASESUARSTOK) values (@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", tbAd.Text);
            komut.Parameters.AddWithValue("@P2", int.Parse(tbAlisFiyat.Text));
            komut.Parameters.AddWithValue("@P3", int.Parse(tbSatisFiyat.Text));
            komut.Parameters.AddWithValue("@P4", int.Parse(tbStok.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Aksesuar Eklenmiştir");
        }
    }
}
