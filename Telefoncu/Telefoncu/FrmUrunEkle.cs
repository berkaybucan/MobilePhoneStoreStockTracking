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
    public partial class FrmUrunEkle : Form
    {
        public FrmUrunEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMarkaEkle frmMarka = new FrmMarkaEkle();
            frmMarka.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmModelEkle frmmodel = new FrmModelEkle();
            frmmodel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAksesuarEkle frmaksesuar = new FrmAksesuarEkle();
            frmaksesuar.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PersonelEkleFrm frmper = new PersonelEkleFrm();
            frmper.Show();
        }
    }
}
