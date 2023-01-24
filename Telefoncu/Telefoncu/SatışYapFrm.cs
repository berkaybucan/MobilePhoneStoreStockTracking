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
    public partial class SatışYapFrm : Form
    {
        public SatışYapFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelefonSatısFrm telefonsat = new TelefonSatısFrm();
            telefonsat.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmaksesuarsatis akssatis = new frmaksesuarsatis();
            akssatis.Show();
        }
    }
}
