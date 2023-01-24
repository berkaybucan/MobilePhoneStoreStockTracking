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
    public partial class AksesuarStokDuzenlemeFrm : Form
    {
        public AksesuarStokDuzenlemeFrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2C6E5LJ;Initial Catalog=DbTelefoncu;Integrated Security=True");
        private void AksesuarStokDuzenlemeFrm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbTelefoncuDataSet3.TBLAKSESUAR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLAKSESUARTableAdapter.Fill(this.dbTelefoncuDataSet3.TBLAKSESUAR);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbAd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tbAlis.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tbSatis.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            tbStok.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLAKSESUAR set AKSESUARALISFIYAT=@P2,AKSESUARSATISFIYAT=@P3,AKASESUARSTOK=@P4 where AKSESUARAD=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", tbAd.Text);
            komut.Parameters.AddWithValue("@P2", int.Parse(tbAlis.Text));
            komut.Parameters.AddWithValue("@P3", int.Parse(tbSatis.Text));
            komut.Parameters.AddWithValue("@P4", int.Parse(tbStok.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilgiler Başarıyla Güncellendi");
            this.tBLAKSESUARTableAdapter.Fill(this.dbTelefoncuDataSet3.TBLAKSESUAR);

        }
    }
}
