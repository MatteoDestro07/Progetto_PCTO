using Progetto_PCTO.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_PCTO
{
    public partial class FrmVendite : Form
    {
        public FrmVendite()
        {
            InitializeComponent();
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienti frmClienti = new FrmClienti();
            frmClienti.ShowDialog();
        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorie frmCategorie = new FrmCategorie();
            frmCategorie.ShowDialog();
        }

        private void prodottiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdotti frmProdotti = new FrmProdotti();
            frmProdotti.ShowDialog();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmVendite_Load(object sender, EventArgs e)
        {
            cmbVisualizzazioneDgv.Items.Add("Clienti");
            cmbVisualizzazioneDgv.Items.Add("Prodotti");
            cmbVisualizzazioneDgv.Items.Add("Dettaglio Vendite");
            cmbVisualizzazioneDgv.Items.Add("Testata Vendite");
            cmbVisualizzazioneDgv.Items.Add("Carrello");
            cmbVisualizzazioneDgv.Items.Add("Categorie");
        }

        private void cmbVisualizzazioneDgv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
