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
    public partial class frmmesajgöndermepaneli : Form
    {
        public frmmesajgöndermepaneli()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2C6E5LJ;Initial Catalog=DbTelefoncu;Integrated Security=True");

        private void frmmesajgöndermepaneli_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbTelefoncuDataSet12.TBLMERKEZLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLMERKEZLERTableAdapter.Fill(this.dbTelefoncuDataSet12.TBLMERKEZLER);

        }
        public string gonderen;

        private void button1_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMESAJLAR (GONDEREN,ALICI,BASLIK,MESAJ) values (@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", gonderen);
            komut.Parameters.AddWithValue("@P2", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@P3", textBox1.Text);
            komut.Parameters.AddWithValue("@P4", richTextBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesajınız iletilmiştir");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }
    }
}
