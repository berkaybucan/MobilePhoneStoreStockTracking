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
    public partial class StokBilgisiKayıtDüzenlemeFrm : Form
    {
        public StokBilgisiKayıtDüzenlemeFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelefonStokDuzenlemeFrm telefonfrm = new TelefonStokDuzenlemeFrm();
            telefonfrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AksesuarStokDuzenlemeFrm aksfrm = new AksesuarStokDuzenlemeFrm();
            aksfrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonelDüzenleFrm perdüzfrm = new PersonelDüzenleFrm();
            perdüzfrm.Show();
        }
    }
}
