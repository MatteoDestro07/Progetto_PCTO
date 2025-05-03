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

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCategorie_Load(object sender, EventArgs e)
        {
            visElencoCategorie();
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

            
        }

        private void cmbModificaId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCategoriaSelezionata = Convert.ToInt32(cmbModificaId.SelectedItem);
            categorieController categorie = new categorieController();
            categorieModel categoriaSelezionata = categorie.elencoCategorie().FirstOrDefault(c => c.IdCategoria == idCategoriaSelezionata);

            if (categoriaSelezionata != null)
            {
                txtDescrizioneCategoria.Text = categoriaSelezionata.DescCategoria;
            }
        }
    }
}
