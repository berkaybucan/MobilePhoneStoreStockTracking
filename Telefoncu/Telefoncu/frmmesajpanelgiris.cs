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
    public partial class frmmesajpanelgiris : Form
    {
        public frmmesajpanelgiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2C6E5LJ;Initial Catalog=DbTelefoncu;Integrated Security=True");
        private void frmmesajpanelgiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLMERKEZLER where KOD=@P1 AND SIFRE=@P2", baglanti);
            komut.Parameters.AddWithValue("@P1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@P2", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmmesajpanel mp = new frmmesajpanel();
                mp.kod = maskedTextBox1.Text;
                mp.Show();

            }
            else
            {
                MessageBox.Show("Hatalı bilgi girdiniz,giriş yapılamadı.");
            }
            baglanti.Close();
        }
    }
}
