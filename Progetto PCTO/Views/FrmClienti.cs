using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_PCTO.Views
{
    public partial class FrmClienti : Form
    {
        public FrmClienti()
        {
            InitializeComponent();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendite frmVendite = new FrmVendite();
            frmVendite.ShowDialog();
        }
    }
}
