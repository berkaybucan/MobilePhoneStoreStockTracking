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
    public partial class frmaksesuarsatis : Form
    {
        public frmaksesuarsatis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2C6E5LJ;Initial Catalog=DbTelefoncu;Integrated Security=True");

        private void frmaksesuarsatis_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutPer = new SqlCommand("Select PERSONELAD from TBLPERSONEL", baglanti);
            SqlDataReader drPer = komutPer.ExecuteReader();
            while (drPer.Read())
            {
                CbPersonel.Items.Add(drPer[0]);
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komutmodel = new SqlCommand("Select AKSESUARAD from TBLAKSESUAR ", baglanti);
            SqlDataReader drmodel = komutmodel.ExecuteReader();
            while (drmodel.Read())
            {
                cbAksesuarlar.Items.Add(drmodel[0]);
            }

            baglanti.Close();
        }

        private void cbAksesuarlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLAKSESUAR where AKSESUARAD=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", cbAksesuarlar.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblStok.Text = dr[4].ToString();
                progressBar1.Value = int.Parse(dr[4].ToString());
                lblSatisFiyat.Text = dr[3].ToString();


            }
            baglanti.Close();
        }
    }
}
