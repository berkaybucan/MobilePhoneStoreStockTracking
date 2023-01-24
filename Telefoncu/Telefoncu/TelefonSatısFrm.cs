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
    public partial class TelefonSatısFrm : Form
    {
        public TelefonSatısFrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2C6E5LJ;Initial Catalog=DbTelefoncu;Integrated Security=True");
        string a;
        private void TelefonSatısFrm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutMARKA = new SqlCommand("Select MARKA from TBLMARKA", baglanti);
            SqlDataReader drMARKA = komutMARKA.ExecuteReader();
            while (drMARKA.Read())
            {
                CbMarka.Items.Add(drMARKA[0]);
                a = drMARKA[0].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komutPer = new SqlCommand("Select PERSONELAD from TBLPERSONEL", baglanti);
            SqlDataReader drPer = komutPer.ExecuteReader();
            while (drPer.Read())
            {
                CbPersonel.Items.Add(drPer[0]);
            }
            baglanti.Close();


            string mmarka = CbMarka.Text;
            baglanti.Open();
            SqlCommand komutmodel = new SqlCommand("Select MODEL from TBLMODEL ", baglanti);
            SqlDataReader drmodel = komutmodel.ExecuteReader();
            while (drmodel.Read())
                {
                    CbModel.Items.Add(drmodel[0]);
                }
    
            baglanti.Close();

            timer1.Enabled = true;

        }

        private void CbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLMODEL where MODEL=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", CbModel.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblStok.Text = dr[5].ToString();
                progressBar1.Value = int.Parse(dr[5].ToString());
                LblTSatisFiyat.Text = dr[4].ToString();


            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (int.Parse(LblStok.Text)>0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLTELSATIS (MARKA,MODEL,IMEI,BARKOD,MUSTERIAD,MUSTERITEL,FIYAT,PERSONEL,TARIH) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)", baglanti);
                komut.Parameters.AddWithValue("@P1", CbMarka.Text);
                komut.Parameters.AddWithValue("@P2", CbModel.Text);
                komut.Parameters.AddWithValue("@P3", txIMEI.Text);
                komut.Parameters.AddWithValue("@P4", txBarkod.Text);
                komut.Parameters.AddWithValue("@P5", txMusteriAd.Text);
                komut.Parameters.AddWithValue("@P6", txMusteriTel.Text);
                komut.Parameters.AddWithValue("@P7", int.Parse(txFiyat.Text.ToString()));
                komut.Parameters.AddWithValue("@P8", CbPersonel.Text);
                komut.Parameters.AddWithValue("@P9", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Open();
                SqlCommand stok = new SqlCommand("Update TBLMODEL set ADET-=1 where MODEL=@PS", baglanti);
                stok.Parameters.AddWithValue("@PS", CbModel.Text);
                stok.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Başarıyla Gerçekleşti");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ürünün Stokta Kalmadığı İçin Satış Gerçekleştirilemedi");
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
