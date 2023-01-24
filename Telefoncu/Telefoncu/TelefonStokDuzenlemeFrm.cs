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
    public partial class TelefonStokDuzenlemeFrm : Form
    {
        public TelefonStokDuzenlemeFrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2C6E5LJ;Initial Catalog=DbTelefoncu;Integrated Security=True");
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TelefonStokDuzenlemeFrm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbTelefoncuDataSet9.TBLMODEL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLMODELTableAdapter5.Fill(this.dbTelefoncuDataSet9.TBLMODEL);




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbModel.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tbAlisFiyat.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            tbSatisFiyat.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tbStok.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutg = new SqlCommand("update TBLMODEL set ALISFIYAT=@P2,SATISFIYAT=@P3,ADET=@P4 where MODEL =@P1", baglanti);
            komutg.Parameters.AddWithValue("@P1", tbModel.Text);
            komutg.Parameters.AddWithValue("@P2", int.Parse(tbAlisFiyat.Text));
            komutg.Parameters.AddWithValue("@P3", int.Parse(tbSatisFiyat.Text));
            komutg.Parameters.AddWithValue("@P4", int.Parse(tbStok.Text));
            komutg.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilgiler Başarıyla Güncellendi");
            this.tBLMODELTableAdapter5.Fill(this.dbTelefoncuDataSet9.TBLMODEL);

        }


    }
}
