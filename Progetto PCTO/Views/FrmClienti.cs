using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Progetto_PCTO.Controllers;
using Progetto_PCTO.Models;

namespace Progetto_PCTO.Views
{
    public partial class FrmClienti : Form
    {
        public FrmClienti() 
        {
            InitializeComponent();
        }

        private void FrmClienti_Load(object sender, EventArgs e)
        {
            visElencoClienti();
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

        private void visElencoClienti()
        {
            clientiController listaAziende = new clientiController();

            dgvClienti.DataSource = null;

            caricaClienti(listaAziende.elencoClienti());

        }

        private void caricaClienti(List<clientiModel> lista)
        {
            dgvClienti.DataSource = lista;
            dgvClienti.ReadOnly = true;
            dgvClienti.Columns["Validita"].Visible = false;
            dgvClienti.ClearSelection();
        }
    }
}
