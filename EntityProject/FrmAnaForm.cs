using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProject
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void buttonKatİslem_Click(object sender, EventArgs e)
        {
            FrmKategoriler fk = new FrmKategoriler();
            fk.Show();
        }

        private void buttonUrunİslem_Click(object sender, EventArgs e)
        {
            FrmUrun fu = new FrmUrun();
            fu.Show();
        }

        private void buttonİstatistik_Click(object sender, EventArgs e)
        {
            Frmİstatistik fi = new Frmİstatistik();
            fi.Show();
        }
    }
}
