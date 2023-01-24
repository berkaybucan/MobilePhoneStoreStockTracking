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
    public partial class FrmModelEkle : Form
    {
        public FrmModelEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2C6E5LJ;Initial Catalog=DbTelefoncu;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmModelEkle_Load(object sender, EventArgs e)

        {
            baglanti.Open();

            SqlCommand komutm = new SqlCommand("Select MARKA from TBLMARKA", baglanti);
            SqlDataReader drm = komutm.ExecuteReader();
            while (drm.Read())
            {
                comboBox2.Items.Add(drm[0]);
            }
            baglanti.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into TBLMODEL (MODEL,ALISFIYAT,SATISFIYAT,ADET,MARKA) values (@P1,@P2,@P3,@P4,@P5)", baglanti);
            komut.Parameters.AddWithValue("@P1", (tbModel.Text+"-"+txtRenk.Text));
            komut.Parameters.AddWithValue("@P2", int.Parse(tbAlisFİyat.Text));
            komut.Parameters.AddWithValue("@P3", int.Parse(tbSatisFiyat.Text));
            komut.Parameters.AddWithValue("@P4", int.Parse(tbAdet.Text));
            komut.Parameters.AddWithValue("@P5", comboBox2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni Model Başarıyla Yüklenmiştir"); 
        }
    }
}
