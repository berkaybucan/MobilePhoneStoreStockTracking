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
    public partial class frmmesajpanel : Form
    {
        public frmmesajpanel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2C6E5LJ;Initial Catalog=DbTelefoncu;Integrated Security=True");
        public string kod;


        private void button1_Click(object sender, EventArgs e)
        {
            frmmesajgöndermepaneli mesajgonder = new frmmesajgöndermepaneli();
            mesajgonder.gonderen = kod;
            mesajgonder.Show();

        }
        void GelenKutusu()
        {
            SqlDataAdapter gelenda = new SqlDataAdapter("Select MERKEZ AS 'Gelen Merkez',BASLIK,MESAJ From TBLMESAJLAR INNER JOIN TBLMERKEZLER ON TBLMESAJLAR.GONDEREN=TBLMERKEZLER.KOD where ALICI=" + kod, baglanti);
            DataTable gelendt = new DataTable();
            gelenda.Fill(gelendt);
            dataGridView1.DataSource = gelendt;
        }
        void GidenKutusu()
        {
            SqlDataAdapter gidenda = new SqlDataAdapter("Select MERKEZ AS 'Gönderilen Merkez',BASLIK,MESAJ From TBLMESAJLAR INNER JOIN TBLMERKEZLER ON TBLMESAJLAR.ALICI=TBLMERKEZLER.KOD where GONDEREN=" + kod, baglanti);
            DataTable gidendt = new DataTable();
            gidenda.Fill(gidendt);
            dataGridView2.DataSource = gidendt;
        }

        private void frmmesajpanel_Load(object sender, EventArgs e)
        {
            lblKod.Text = kod;
            GelenKutusu();
            GidenKutusu();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select MERKEZ From TBLMERKEZLER where KOD=" + kod, baglanti);
            SqlDataReader drmerkez = komut.ExecuteReader();
            while (drmerkez.Read())
            {
                lblmerkez.Text = drmerkez[0].ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
