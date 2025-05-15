using Progetto_PCTO.Controllers;
using Progetto_PCTO.Models;
using Progetto_PCTO.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
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
            cmbVisualizzazioneDgv.Items.Add("Categorie");

            caricaCmbCategoria(cmbCategoriaVendita);
            caricaCmbEliminaProdotto(cmbEliminaProdotto);
            caricaCmbEliminaProdotto(cmbNomeProdottoModifica);

            visCarrello(dgvCarrello);
        }

        private void caricaCmbEliminaProdotto(ComboBox cmb)
        {
            cmb.Items.Clear();
            carrelloController carrello = new carrelloController();
            List<carrelloModel> listaCarrello = carrello.elencoCarrello();

            foreach (var carrelloItem in listaCarrello)
            {
                fromCarrelloConvertiIdInString(carrello, "cmb", cmb);
            }
        }

        private void visCarrello(DataGridView dgv)
        {
            dgv.DataSource = null;
            carrelloController carrello = new carrelloController();
            fromCarrelloConvertiIdInString(carrello, "dgv", null);
        }

        private void fromCarrelloConvertiIdInString(carrelloController carrello, string azione, ComboBox cmb)
        {
            prodottiController prodottiController = new prodottiController();
            categorieController categorieController = new categorieController();

            List<prodottiModel> listaProdotti = prodottiController.elencoProdotti();
            List<categorieModel> listaCategorie = categorieController.elencoCategorie();

            var carrelloData = carrello.elencoCarrello().Select(item => new
            {
                NomeProdotto = listaProdotti.FirstOrDefault(p => p.IdProdotto == item.IdProdotto)?.DescProdotto,
                NomeCategoria = listaCategorie.FirstOrDefault(c => c.IdCategoria == item.IdCategoria)?.DescCategoria,
                Prezzo = item.Prezzo,
                Quantita = item.Quantita,
            }).ToList();

            if (azione == "cmb")
            {
                cmb.Items.Clear();
                foreach (var carrelloItem in carrelloData)
                {
                    cmb.Items.Add(carrelloItem.NomeProdotto);
                }
            }
            else if (azione == "dgv")
            {
                dgvCarrello.DataSource = carrelloData;
                dgvCarrello.ReadOnly = true;
                dgvCarrello.ClearSelection();
            }
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

                case "Dettaglio Vendite":
                    visDettaglioVendite();
                    break;

                case "Testata Vendite":
                    visTestataVendite();
                    break;
            }
        }

        private void visTestataVendite()
        {
            testataVenditeController listaTestata = new testataVenditeController();

            dgvVendite.DataSource = null;

            caricaTestataVendite(listaTestata.elencoTestataVendita());
        }

        private void visDettaglioVendite()
        {
            dettaglioVenditeController listaDettaglio = new dettaglioVenditeController();

            dgvVendite.DataSource = null;
            
            caricaDettaglioVendite(listaDettaglio.elencoDettaglioVendita());
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

        private void caricaTestataVendite(List<testataVenditeModel> testataVenditeModels)
        {
            clientiController clientiController = new clientiController();
            List<clientiModel> listaClienti = clientiController.elencoClienti();

            var testataConNomeCliente = testataVenditeModels.Select(t => new
            {
                t.NumeroFattura,
                Cliente = listaClienti.FirstOrDefault(c => c.IdCliente == t.ClienteID) != null
                    ? $"{listaClienti.FirstOrDefault(c => c.IdCliente == t.ClienteID).Nome} {listaClienti.FirstOrDefault(c => c.IdCliente == t.ClienteID).Cognome}"
                    : "CLIENTE ELIMINATO DALL'ELENCO",
                t.Data,
                t.Indirizzo
            }).ToList();

            dgvVendite.DataSource = testataConNomeCliente;
            dgvVendite.ReadOnly = true;
            dgvVendite.ClearSelection();
        }

        private void caricaDettaglioVendite(List<dettaglioVenditeModel> lista)
        {
            prodottiController prodottiController = new prodottiController();
            List<prodottiModel> listaProdotti = prodottiController.elencoProdotti();

            var dettaglioConNomeProdotto = lista.Select(d => new
            {
                d.IdDettaglioVendita,
                d.NumeroFattura,
                d.IdProdotto,
                NomeProdotto = listaProdotti.FirstOrDefault(p => p.IdProdotto == d.IdProdotto)?.DescProdotto,
                d.QuantitaVenduta
            }).ToList();

            dgvVendite.DataSource = dettaglioConNomeProdotto;
            dgvVendite.ReadOnly = true;
            dgvVendite.Columns["IdProdotto"].Visible = false;
            dgvVendite.ClearSelection();
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
            if (cmbCategoriaVendita.SelectedIndex != -1)
            {
                if (cmbProdottoVendita.SelectedIndex != -1)
                {
                    if (nudQuantitàVendita.Value != 0 && prodottoDisponibile())
                    {
                        carrelloController carrello = new carrelloController();
                        carrello.carrello.IdProdotto = convertiProdottoInId(cmbProdottoVendita.Text);
                        carrello.carrello.IdCategoria = covertiCategInId();
                        carrello.carrello.Prezzo = nudQuantitàVendita.Value * getPrezzoById(cmbProdottoVendita.Text);
                        carrello.carrello.Quantita = Convert.ToInt32(nudQuantitàVendita.Value);
                        carrello.aggiungi();

                        visCarrello(dgvCarrello);
                        caricaCmbEliminaProdotto(cmbEliminaProdotto);
                        caricaCmbEliminaProdotto(cmbNomeProdottoModifica);

                        cmbProdottoVendita.SelectedIndex = -1;
                        nudQuantitàVendita.Value = 0;
                        cmbCategoriaVendita.SelectedIndex = -1;
                    }
                    else
                        MessageBox.Show("Il prodotto non è disponibile o devi inserire una quantità valida", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Selezionare un prodotto", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Selezionare una categoria", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool prodottoDisponibile()
        {
            string nomeProdotto = cmbProdottoVendita.Text;
            if (string.IsNullOrEmpty(nomeProdotto))
                return false;

            int quantitaRichiesta = (int)nudQuantitàVendita.Value;
            if (quantitaRichiesta <= 0)
                return false;

            prodottiController prodottiController = new prodottiController();
            List<prodottiModel> listaProdotti = prodottiController.elencoProdotti();

            var prodotto = listaProdotti.FirstOrDefault(p => p.DescProdotto == nomeProdotto);

            if (prodotto == null)
                return false;

            return prodotto.Quantita >= quantitaRichiesta;
        }

        private decimal getPrezzoById(string text)
        {
            decimal prezzo = 0;

            prodottiController prodottiController = new prodottiController();
            List<prodottiModel> listaProdotti = prodottiController.elencoProdotti();

            foreach (var prod in listaProdotti)
            {
                if (prod.DescProdotto == text)
                {
                    prezzo = Convert.ToDecimal(prod.Prezzo);
                    break;
                }
            }

            return prezzo;
        }

        private int convertiProdottoInId(string prodotto)
        {
            int id = 0;
            prodottiController prodottiController = new prodottiController();
            List<prodottiModel> listaProdotti = prodottiController.elencoProdotti();

            foreach (var prod in listaProdotti)
            {
                if (prod.DescProdotto == prodotto)
                {
                    id = prod.IdProdotto;
                    break;
                }
            }

            return id;
        }

        private void nudQuantitàVendita_ValueChanged(object sender, EventArgs e)
        {
            lblPrezzo.Text = (getPrezzoById(cmbProdottoVendita.Text) * nudQuantitàVendita.Value).ToString("C2");
        }

        private void btnSvuotaCarrello_Click(object sender, EventArgs e)
        {
            if (dgvCarrello.Rows.Count == 0)
            {
                MessageBox.Show("Il carrello è vuoto", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                carrelloController carrello = new carrelloController();
                carrello.svuotaCarrello("");
                visCarrello(dgvCarrello);
                dgvCarrello.DataSource = null;
                
                caricaCmbEliminaProdotto(cmbEliminaProdotto);
                caricaCmbEliminaProdotto(cmbNomeProdottoModifica);
            }
        }

        private void btnEliminaProdotto_Click(object sender, EventArgs e)
        {
            carrelloController carrello = new carrelloController();
            carrello.carrello.IdProdotto = convertiProdottoInId(cmbEliminaProdotto.Text);
            carrello.elimina();

            visCarrello(dgvCarrello);
            caricaCmbEliminaProdotto(cmbEliminaProdotto);
            caricaCmbEliminaProdotto(cmbNomeProdottoModifica);
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if(cmbNomeProdottoModifica.SelectedIndex != -1)
            {
                if(nudQuantitaProdotto.Value != 0)
                {
                    carrelloController carrello = new carrelloController();
                    carrello.carrello.IdProdotto = convertiProdottoInId(cmbNomeProdottoModifica.Text);
                    carrello.carrello.Quantita = Convert.ToInt32(nudQuantitaProdotto.Value);
                    carrello.carrello.Prezzo = getPrezzoById(cmbNomeProdottoModifica.Text) * Convert.ToDecimal(nudQuantitaProdotto.Value);
                    carrello.modifica();

                    visCarrello(dgvCarrello);

                    nudQuantitaProdotto.Value = 0;
                    cmbNomeProdottoModifica.SelectedIndex = -1;
                }
                else
                    MessageBox.Show("Inserire una quantità valida", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Selezionare un prodotto", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cmbNomeProdottoModifica_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categ = fromNomeGetCateg(cmbNomeProdottoModifica.Text);
            lblCategoriaProdotto.Text = categ;
        }

        private string fromNomeGetCateg(string prodotto)
        {
            prodottiController prodottiController = new prodottiController();
            List<prodottiModel> listaProdotti = prodottiController.elencoProdotti();

            foreach (var prod in listaProdotti)
            {
                if (prod.DescProdotto == prodotto)
                {
                    return getNomeCategoriaById(prod.IdCategoria);
                }
            }

            return string.Empty;
        }

        private string getNomeCategoriaById(int idCategoria)
        {
            categorieController categorieController = new categorieController();
            List<categorieModel> listaCategorie = categorieController.elencoCategorie();

            foreach (var categoria in listaCategorie)
            {
                if (categoria.IdCategoria == idCategoria)
                {
                    return categoria.DescCategoria;
                }
            }

            return string.Empty;
        }

        private void btnConfermaAcquisto_Click(object sender, EventArgs e)
        {
            carrelloController carrelloController = new carrelloController();
            List<carrelloModel> listaCarrello = carrelloController.elencoCarrello();

            if (listaCarrello.Count == 0)
            {
                MessageBox.Show("Il carrello è vuoto", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                FrmConfermaAcquisto frmConfermaAcquisto = new FrmConfermaAcquisto();
                frmConfermaAcquisto.ShowDialog();
                visCarrello(dgvCarrello);
            }
        }

        private void statisticheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStatistiche frmStatistiche = new FrmStatistiche();
            frmStatistiche.ShowDialog();
        }
    }
}
