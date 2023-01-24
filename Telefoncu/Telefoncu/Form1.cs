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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmUrunEkle urunekle = new FrmUrunEkle();
            urunekle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StokBilgisiKayıtDüzenlemeFrm stokfrm = new StokBilgisiKayıtDüzenlemeFrm();
            stokfrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SatışYapFrm satfrm = new SatışYapFrm();
            satfrm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Satış_Geçmişi sg = new Satış_Geçmişi();
            sg.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmmesajpanelgiris mesajgiris = new frmmesajpanelgiris();
            mesajgiris.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
