using Progetto_PCTO.Controllers;
using Progetto_PCTO.Models;
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
    public partial class FrmCategorie : Form
    {
        public FrmCategorie()
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
            FrmVendite frmVendite = new FrmVendite();
            frmVendite.ShowDialog();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCategorie_Load(object sender, EventArgs e)
        {
            visElencoCategorie();
            rbAggiungi.Checked = true;
            controllaChk();
            caricaCmb(cmbModificaId);
            caricaCmb(cmbEliminaCliente);
        }

        private void visElencoCategorie()
        {
            categorieController listaCategorie = new categorieController();

            dgv.DataSource = null;

            caricaCategorie(listaCategorie.elencoCategorie());
        }

        private void caricaCategorie(List<categorieModel> lista)
        {
            dgv.DataSource = lista;
            dgv.ReadOnly = true;
            dgv.Columns["Validita"].Visible = false;

            dgv.Columns["IdCategoria"].HeaderText = "Id";
            dgv.Columns["DescCategoria"].HeaderText = "Descrizione";

            dgv.ClearSelection();
        }

        private void btnAggiungiCategoria_Click(object sender, EventArgs e)
        {
            if (txtDescrizioneCategoria.Text != string.Empty)
            {
                categorieController categoria = new categorieController();
                categoria.categorie.DescCategoria = txtDescrizioneCategoria.Text;
                categoria.aggiungi();
                txtDescrizioneCategoria.Clear();
                visElencoCategorie();
                caricaCmb(cmbModificaId);
                caricaCmb(cmbEliminaCliente);
            }
            else
            {
                MessageBox.Show("Inserire la descrizione della categoria","ERRORE",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void rbAggiungi_CheckedChanged(object sender, EventArgs e)
        {
            controllaChk();
        }

        private void rbModifica_CheckedChanged(object sender, EventArgs e)
        {
           controllaChk();
        }

        private void rbElimina_CheckedChanged(object sender, EventArgs e)
        {
            controllaChk();
        }

        public void controllaChk()
        {
            if (rbAggiungi.Checked)
            {
                grbAggiungiCategoria.Visible = true;
                grbModificaCategoria.Visible = false;
                grbElimina.Visible = false;
            }
            else if (rbModifica.Checked)
            {
                grbAggiungiCategoria.Visible = false;
                grbModificaCategoria.Visible = true;
                grbElimina.Visible = false;
            }
            else if (rbElimina.Checked)
            {
                grbAggiungiCategoria.Visible = false;
                grbModificaCategoria.Visible = false;
                grbElimina.Visible = true;
            }
        }

        private void btnModificaCliente_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtModifica.Text))
            {
                categorieController categorie = new categorieController();
                categorie.categorie.IdCategoria = Convert.ToInt32(cmbModificaId.SelectedItem);
                categorie.categorie.DescCategoria = txtModifica.Text;
                categorie.modifica();
                txtModifica.Clear();
                visElencoCategorie();
                caricaCmb(cmbModificaId);
                caricaCmb(cmbEliminaCliente);
            }
            else
            {
                MessageBox.Show("Inserire la descrizione della categoria", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cmbModificaId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCategoriaSelezionata = Convert.ToInt32(cmbModificaId.SelectedItem);
            categorieController categorie = new categorieController();
            categorieModel categoriaSelezionata = categorie.elencoCategorie().FirstOrDefault(c => c.IdCategoria == idCategoriaSelezionata);

            if (categoriaSelezionata != null)
            {
                txtModifica.Text = categoriaSelezionata.DescCategoria;
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            categorieController categorie = new categorieController();
            categorie.categorie.IdCategoria = Convert.ToInt32(cmbEliminaCliente.SelectedItem);
            categorie.elimina();
            visElencoCategorie();
            caricaCmb(cmbModificaId);
            caricaCmb(cmbEliminaCliente);
        }

        private void caricaCmb(ComboBox cmb)
        {
            cmb.Items.Clear();
            categorieController categorieController = new categorieController();
            List<categorieModel> listaCategorie = categorieController.elencoCategorie();
            foreach (var categorie in listaCategorie)
            {
                if (categorie.Validita == ' ')
                    cmb.Items.Add(categorie.IdCategoria);
            }
        }
    }
}
