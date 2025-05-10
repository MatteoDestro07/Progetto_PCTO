using Progetto_PCTO.Controllers;
using Progetto_PCTO.Models;
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

            caricaCmbCategoria(cmbCategoriaVendita);
        }

        private void cmbVisualizzazioneDgv_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbVisualizzazioneDgv.Text)
            {
                case "Clienti":
                    visElencoClienti();
                    break;

                case "Prodotti":
                    visElencoProdotti();
                    break;

                case "Categorie":
                    visElencoCategorie();
                    break;
            }
        }

        private void visElencoClienti()
        {
            clientiController listaClienti = new clientiController();

            dgvVendite.DataSource = null;

            caricaClienti(listaClienti.elencoClienti());

        }

        private void visElencoProdotti()
        {
            prodottiController listaProdotti = new prodottiController();

            dgvVendite.DataSource = null;

            caricaProdotti(listaProdotti.elencoProdotti());
        }


        private void visElencoCategorie()
        {
            categorieController listaCategorie = new categorieController();

            dgvVendite.DataSource = null;

            caricaCategorie(listaCategorie.elencoCategorie());
        }

        private void caricaClienti(List<clientiModel> lista)
        {
            dgvVendite.DataSource = lista;
            dgvVendite.ReadOnly = true;
            dgvVendite.Columns["Validita"].Visible = false;
            dgvVendite.ClearSelection();
        }

        private void caricaProdotti(List<prodottiModel> lista)
        {
            dgvVendite.DataSource = lista;
            dgvVendite.ReadOnly = true;
            dgvVendite.Columns["Validita"].Visible = false;
            dgvVendite.ClearSelection();
        }

        private void caricaCategorie(List<categorieModel> lista)
        {
            dgvVendite.DataSource = lista;
            dgvVendite.ReadOnly = true;
            dgvVendite.Columns["Validita"].Visible = false;

            dgvVendite.Columns["IdCategoria"].HeaderText = "Id";
            dgvVendite.Columns["DescCategoria"].HeaderText = "Descrizione";

            dgvVendite.ClearSelection();
        }

        private void caricaCmbCategoria(ComboBox cmb)
        {
            cmb.Items.Clear();
            categorieController categorieController = new categorieController();
            List<categorieModel> listaCategorie = categorieController.elencoCategorie();
            foreach (var categorie in listaCategorie)
            {
                if (categorie.Validita == ' ')
                    cmb.Items.Add(categorie.DescCategoria);
            }
        }

        private void cmbCategoriaVendita_SelectedIndexChanged(object sender, EventArgs e)
        {
            caricaCmbPerCategoria(cmbProdottoVendita, cmbCategoriaVendita.Text);
        }

        private void caricaCmbPerCategoria(ComboBox cmb, string text)
        {
            prodottiController prodottiController = new prodottiController();
            List<prodottiModel> listaProdotti = prodottiController.elencoProdotti();

            cmb.Items.Clear();

            foreach (var prodotti in listaProdotti)
            {
                if (prodotti.Validita == ' ' && prodotti.IdCategoria == covertiCategInId())
                    cmb.Items.Add(prodotti.DescProdotto);
            }
        }

        private int covertiCategInId()
        {
            int id = 0;
            categorieController categorieController = new categorieController();
            List<categorieModel> listaCategorie = categorieController.elencoCategorie();
            foreach (var categoria in listaCategorie)
            {
                if (categoria.DescCategoria == cmbCategoriaVendita.Text)
                    id = categoria.IdCategoria;
            }
            return id;
        }

        private void btnAggiungiProdotto_Click(object sender, EventArgs e)
        {
            if(cmbCategoriaVendita.SelectedIndex != -1)
            {
                if(cmbProdottoVendita.SelectedIndex != -1)
                {
                    if(nudQuantitàVendita.Value != 0)
                    {
                        
                    }
                    else
                        MessageBox.Show("Inserire una quantità valida", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Selezionare un prodotto", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Selezionare una categoria", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
