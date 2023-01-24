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
    public partial class PersonelDüzenleFrm : Form
    {
        public PersonelDüzenleFrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2C6E5LJ;Initial Catalog=DbTelefoncu;Integrated Security=True");

        private void PersonelDüzenleFrm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbTelefoncuDataSet4.TBLPERSONEL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLPERSONELTableAdapter.Fill(this.dbTelefoncuDataSet4.TBLPERSONEL);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLPERSONEL set PERSONELAD=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.tBLPERSONELTableAdapter.Fill(this.dbTelefoncuDataSet4.TBLPERSONEL);
            MessageBox.Show("Personel Bilgisi Başarıyla Güncellenmiştir");


        }
    }
}
