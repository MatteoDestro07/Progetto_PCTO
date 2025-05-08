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
    public partial class FrmProdotti : Form
    {
        public FrmProdotti()
        {
            InitializeComponent();
        }

        private void prodottiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorie frmCategorie = new FrmCategorie();
            frmCategorie.ShowDialog();
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienti frmClienti = new FrmClienti();
            frmClienti.ShowDialog();
        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProdotti_Load(object sender, EventArgs e)
        {
            visElencoProdotti();

            caricaCmb(cmbIdImmagineDaVisualizzare);
            caricaCmb(cmbModificaId);
            caricaCmb(cmbEliminaCliente);
            caricaCmbCategoria(cmbIdCategoria);
            caricaCmbCategoria(cmbModificaCategoria);

            cmbEliminaCliente.SelectedIndex = 0;
            cmbIdCategoria.SelectedIndex = 0;
            cmbModificaCategoria.SelectedIndex = 0;
            cmbModificaId.SelectedIndex = 0;
        }

        private void caricaCmbCategoria(ComboBox cmb)
        {
            categorieController categorieController = new categorieController();
            List<categorieModel> listaCategorie = categorieController.elencoCategorie();
            cmb.Items.Clear();
            foreach (var categorie in listaCategorie)
            {
                if (categorie.Validita == ' ')
                    cmb.Items.Add(categorie.DescCategoria);
            }
        }

        private void caricaCmb(ComboBox cmb)
        {
            cmb.Items.Clear();
            prodottiController prodottiController = new prodottiController();
            List<prodottiModel> listaProdotti = prodottiController.elencoProdotti();
            foreach (var prodotti in listaProdotti)
            {
                if (prodotti.Validita == ' ')
                    cmb.Items.Add(prodotti.IdProdotto);
            }
        }

        private void visElencoProdotti()
        {
            prodottiController listaProdotti = new prodottiController();

            dgv.DataSource = null;

            caricaProdotti(listaProdotti.elencoProdotti());
        }

        private void caricaProdotti(List<prodottiModel> lista)
        {
            dgv.DataSource = lista;
            dgv.ReadOnly = true;
            dgv.Columns["Validita"].Visible = false;
            dgv.ClearSelection();
        }

        private void cmbIdImmagineDaVisualizzare_SelectedIndexChanged(object sender, EventArgs e)
        {
            prodottiController prodottiController = new prodottiController();
            string img = prodottiController.getImg(Convert.ToInt32(cmbIdImmagineDaVisualizzare.Text));
            picImmagineProdotto.ImageLocation = img;
            picImmagineProdotto.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if(txtAggiungiDescrizione.Text != string.Empty)
            {
                if(nudPrezzoUnitario.Text != string.Empty)
                {
                    if(nudQuantita.Text != string.Empty)
                    {
                        if(txtAggiungiURLimmagine.Text != string.Empty)
                        {
                            prodottiController prodotto = new prodottiController();
                            prodotto.prodotti.IdCategoria = Convert.ToInt32(cmbIdCategoria.SelectedIndex + 1);
                            prodotto.prodotti.DescProdotto = txtAggiungiDescrizione.Text;
                            prodotto.prodotti.Prezzo = nudPrezzoUnitario.Text;
                            prodotto.prodotti.Quantita = Convert.ToInt32(nudQuantita.Text);
                            prodotto.prodotti.Immagine = txtAggiungiURLimmagine.Text;
                            prodotto.aggiungi();
                            visElencoProdotti();

                            txtAggiungiDescrizione.Clear();
                            nudPrezzoUnitario.Value = 0;
                            nudQuantita.Value = 0;
                            txtAggiungiURLimmagine.Clear();
                            cmbIdCategoria.SelectedIndex = 0;

                            caricaCmb(cmbIdImmagineDaVisualizzare);
                            caricaCmb(cmbModificaId);
                            caricaCmb(cmbEliminaCliente);

                        }
                        else
                            MessageBox.Show("Inserire l'url dell'immagine", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Inserire la quantità del prodotto", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Inserire il prezzo del prodotto", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Inserire la descrizione del prodotto", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            prodottiController prodotti = new prodottiController();
            prodotti.prodotti.IdProdotto = Convert.ToInt32(cmbEliminaCliente.SelectedItem);
            prodotti.elimina();
            visElencoProdotti();
            caricaCmb(cmbModificaId);
            caricaCmb(cmbEliminaCliente);
            caricaCmb(cmbIdImmagineDaVisualizzare);
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (cmbModificaId.SelectedIndex != -1)
            {
                if(cmbModificaCategoria.SelectedIndex != - 1)
                {
                    if (txtModificaDescrizione.Text != string.Empty)
                    {
                        if (nudModificaPrezzoUnitario.Text != string.Empty)
                        {
                            if (nudModificaQuantita.Text != string.Empty)
                            {
                                if (txtModificaURLimmagine.Text != string.Empty)
                                {
                                    prodottiController prodotti = new prodottiController();
                                    prodotti.prodotti.IdProdotto = Convert.ToInt32(cmbModificaId.SelectedItem);
                                    prodotti.prodotti.IdCategoria = Convert.ToInt32(cmbModificaCategoria.SelectedIndex + 1);
                                    prodotti.prodotti.DescProdotto = txtModificaDescrizione.Text;
                                    prodotti.prodotti.Prezzo = nudModificaPrezzoUnitario.Text;
                                    prodotti.prodotti.Quantita = Convert.ToInt32(nudModificaQuantita.Text);
                                    prodotti.prodotti.Immagine = txtModificaURLimmagine.Text;
                                    prodotti.modifica();
                                    visElencoProdotti();
                                    completaCampi();

                                    txtModificaDescrizione.Clear();
                                    nudModificaPrezzoUnitario.Value = 0;
                                    nudModificaQuantita.Value = 0;
                                    txtModificaURLimmagine.Clear();
                                    cmbIdCategoria.SelectedIndex = 0;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void cmbModificaId_SelectedIndexChanged(object sender, EventArgs e)
        {
            completaCampi();
        }

        private void completaCampi()
        {
            int idProdottoSelezionato = Convert.ToInt32(cmbModificaId.SelectedItem);
            prodottiController prodotti = new prodottiController();
            prodottiModel prodottoSelezionato = prodotti.elencoProdotti().FirstOrDefault(p => p.IdProdotto == idProdottoSelezionato);

            if (prodottoSelezionato != null)
            {
                txtModificaDescrizione.Text = prodottoSelezionato.DescProdotto;
                nudModificaPrezzoUnitario.Value = Convert.ToDecimal(prodottoSelezionato.Prezzo);
                nudModificaQuantita.Value = prodottoSelezionato.Quantita;
                txtModificaURLimmagine.Text = prodottoSelezionato.Immagine;
                cmbModificaCategoria.SelectedIndex = prodottoSelezionato.IdCategoria - 1;
            }
        }
    }
}
