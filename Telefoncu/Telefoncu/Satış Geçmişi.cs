using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefoncu
{
    public partial class Satış_Geçmişi : Form
    {
        public Satış_Geçmişi()
        {
            InitializeComponent();
        }

        private void Satış_Geçmişi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbTelefoncuDataSet11.TBLTELSATIS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLTELSATISTableAdapter.Fill(this.dbTelefoncuDataSet11.TBLTELSATIS);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
