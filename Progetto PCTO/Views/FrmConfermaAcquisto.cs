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

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using System.IO;

namespace Progetto_PCTO.Views
{
    public partial class FrmConfermaAcquisto : Form
    {
        public FrmConfermaAcquisto()
        {
            InitializeComponent();
        }

        private void FrmConfermaAcquisto_Load(object sender, EventArgs e)
        {
            visCarrello(dgvCarrello);
            calcolaPrezzoTotale();
            caricaCmbClienti(cmbCliente);
            caricaCmbModalitaDiPagamento(cmbModalitàDiPagamento);
        }

        private void caricaCmbModalitaDiPagamento(ComboBox cmb)
        {
            cmb.Items.Clear();

            cmb.Items.Add("Contanti");
            cmb.Items.Add("Carta di credito");
            cmb.Items.Add("Bonifico bancario");
            cmb.Items.Add("PayPal");
            cmb.Items.Add("Contrassegno");
            cmb.Items.Add("Satispay");
            cmb.Items.Add("Apple Pay");
            cmb.Items.Add("Google Pay");
            cmb.Items.Add("Scalapay");
            cmb.Items.Add("Klarna");
            cmb.Items.Add("Pagamento in rate");
        }

        private void caricaCmbClienti(ComboBox cmb)
        {
            clientiController clienti = new clientiController();
            List<clientiModel> listaClienti = clienti.elencoClienti();

            cmb.Items.Clear();
            foreach (var cliente in listaClienti)
            {
                cmb.Items.Add(cliente.Nome);
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            clientiController clienti = new clientiController();
            List<clientiModel> listaClienti = clienti.elencoClienti();

            string nomeCliente = cmbCliente.SelectedItem.ToString();
            var clienteSelezionato = listaClienti.FirstOrDefault(c => c.Nome == nomeCliente);
            lblCognomeCliente.Text = clienteSelezionato?.Cognome;
        }

        private void calcolaPrezzoTotale()
        {
            carrelloController carrello = new carrelloController();
            List<carrelloModel> listaCarrello = carrello.elencoCarrello();

            decimal prezzoTotale = 0;
            foreach (var item in listaCarrello)
            {
                prezzoTotale += item.Prezzo;
            }

            lblPrezzoTotale.Text = prezzoTotale.ToString("C");
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

        private void btnConferma_Click(object sender, EventArgs e)
        {
            if(cmbCliente.SelectedIndex != -1)
            {
                if(cmbModalitàDiPagamento.SelectedIndex != -1)
                {
                    if(txtIndirizzoPartenza.Text != string.Empty)
                    {
                        if (txtIndirizzoDiConsegna.Text != string.Empty) 
                        { 
                            testataVenditeController testataVendite = new testataVenditeController();
                            List<testataVenditeModel> listaTestataVendite = testataVendite.elencoTestataVendita();

                            testataVendite.testataVendita.NumeroFattura = listaTestataVendite.Count + 1;
                            testataVendite.testataVendita.ClienteID = getIdClienteFromNome(cmbCliente.Text);
                            testataVendite.testataVendita.Data = DateTime.Now;
                            testataVendite.testataVendita.Indirizzo = txtIndirizzoDiConsegna.Text;
                            testataVendite.aggiungi();

                            caricaDettaglio(testataVendite.testataVendita.NumeroFattura);

                            carrelloController carrello = new carrelloController();
                            List<carrelloModel> listaCarrello = carrello.elencoCarrello();

                            carrello.svuotaCarrello("C");
                            generaRicevuta(testataVendite.testataVendita.NumeroFattura);
                            MessageBox.Show("Acquisto effettuato con successo, ricevuta generata", "Acquisto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
                        else
                            MessageBox.Show("Inserire un indirizzo di destinazione", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Inserire un indirizzo di partenza", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Selezionare una modalità di pagamento", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Selezionare un cliente", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void caricaDettaglio(int fattura)
        {
            dettaglioVenditeController dettaglioVendite = new dettaglioVenditeController();
            List<dettaglioVenditeModel> listaDettaglioVendite = dettaglioVendite.elencoDettaglioVendita();

            carrelloController carrello = new carrelloController();
            List<carrelloModel> listaCarrello = carrello.elencoCarrello();

            foreach(var item in listaCarrello)
            {
                dettaglioVendite.dettaglioVendita.NumeroFattura = fattura;
                dettaglioVendite.dettaglioVendita.IdProdotto = item.IdProdotto;
                dettaglioVendite.dettaglioVendita.QuantitaVenduta = item.Quantita;
                dettaglioVendite.aggiungi();
            }
        }

        private int getIdClienteFromNome(string nome)
        {
            clientiController clienti = new clientiController();
            List<clientiModel> listaClienti = clienti.elencoClienti();
            var clienteSelezionato = listaClienti.FirstOrDefault(c => c.Nome == nome);
            return clienteSelezionato?.IdCliente ?? 0;
        }

        private void generaRicevuta(int numeroFattura)
        {
            string cartellaDestinazione = Application.StartupPath + "\\Fatture";
            Directory.CreateDirectory(cartellaDestinazione);
            string pathDocx = Path.Combine(cartellaDestinazione, $"Ricevuta_{numeroFattura}.docx");

            // Recupera dati
            testataVenditeController testata = new testataVenditeController();
            var fattura = testata.elencoTestataVendita().FirstOrDefault(f => f.NumeroFattura == numeroFattura);

            dettaglioVenditeController dettagli = new dettaglioVenditeController();
            var listaDettagli = dettagli.elencoDettaglioVendita().Where(d => d.NumeroFattura == numeroFattura).ToList();

            prodottiController prodotti = new prodottiController();
            List<prodottiModel> listaProdotti = prodotti.elencoProdotti();

            clientiController clienti = new clientiController();
            var cliente = clienti.elencoClienti().FirstOrDefault(c => c.IdCliente == fattura.ClienteID);

            // Crea il file Word
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Create(pathDocx, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDoc.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = new Body();

                // Intestazione azienda
                body.Append(new Paragraph(new Run(new Text("I.I.S. G.Valluri"))));
                body.Append(new Paragraph(new Run(new Text("Via S. Michele, 68, 12045 Fossano CN"))));
                body.Append(new Paragraph(new Run(new Text("0172694969 - vallauri@vallauri.com"))));
                body.Append(new Paragraph(new Run(new Text("http://www.vallauri.edu/"))));
                body.Append(new Paragraph(new Run(new Text(""))));

                // Titolo fattura
                body.Append(new Paragraph(new Run(new Text("FATTURA"))) { ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center }) });
                body.Append(new Paragraph(new Run(new Text(""))));

                // Dati Fattura
                body.Append(new Paragraph(new Run(new Text($"Data: {fattura.Data.ToShortDateString()}"))));
                body.Append(new Paragraph(new Run(new Text($"Numero Fattura: {fattura.NumeroFattura}"))));
                body.Append(new Paragraph(new Run(new Text($"Modalità di pagamento: {cmbModalitàDiPagamento.Text}"))));
                body.Append(new Paragraph(new Run(new Text(""))));

                // Cliente
                body.Append(new Paragraph(new Run(new Text($"Cliente: {cliente.Nome} {cliente.Cognome}"))));
                body.Append(new Paragraph(new Run(new Text($"Indirizzo: {txtIndirizzoPartenza.Text}"))));
                body.Append(new Paragraph(new Run(new Text($"Telefono: {txtNumeroDiTelefono.Text}"))));
                body.Append(new Paragraph(new Run(new Text($"Email: {cliente.Email}"))));
                body.Append(new Paragraph(new Run(new Text(""))));

                // Consegna
                body.Append(new Paragraph(new Run(new Text($"Indirizzo di consegna: {txtIndirizzoDiConsegna.Text}"))));
                body.Append(new Paragraph(new Run(new Text(""))));

                // Tabella Prodotti
                Table table = new Table();
                TableProperties props = new TableProperties(
                    new TableBorders(
                        new TopBorder() { Val = BorderValues.Single },
                        new BottomBorder() { Val = BorderValues.Single },
                        new LeftBorder() { Val = BorderValues.Single },
                        new RightBorder() { Val = BorderValues.Single },
                        new InsideHorizontalBorder() { Val = BorderValues.Single },
                        new InsideVerticalBorder() { Val = BorderValues.Single }
                    )
                );
                table.AppendChild(props);

                // Header Tabella
                TableRow header = new TableRow();
                header.Append(new TableCell(new Paragraph(new Run(new Text("Descrizione")))));
                header.Append(new TableCell(new Paragraph(new Run(new Text("Q.tà")))));
                header.Append(new TableCell(new Paragraph(new Run(new Text("Prezzo unitario")))));
                header.Append(new TableCell(new Paragraph(new Run(new Text("Importo")))));
                table.Append(header);

                decimal totale = 0;

                foreach (var item in listaDettagli)
                {
                    var prodotto = listaProdotti.FirstOrDefault(p => p.IdProdotto == item.IdProdotto);

                    TableRow row = new TableRow();
                    row.Append(new TableCell(new Paragraph(new Run(new Text(prodotto?.DescProdotto ?? "Prodotto")))));
                    row.Append(new TableCell(new Paragraph(new Run(new Text(item.QuantitaVenduta.ToString())))));
                    row.Append(new TableCell(new Paragraph(new Run(new Text(prodotto?.Prezzo)))));
                    decimal importo = Convert.ToDecimal(prodotto.Prezzo) * item.QuantitaVenduta;
                    totale += importo;
                    row.Append(new TableCell(new Paragraph(new Run(new Text(importo.ToString("C"))))));
                    table.Append(row);
                }

                body.Append(table);

                // Totale
                body.Append(new Paragraph(new Run(new Text(""))));
                body.Append(new Paragraph(new Run(new Text($"Totale Fattura: {totale.ToString("C")}"))) { ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Right }) });

                // Note
                body.Append(new Paragraph(new Run(new Text(""))));
                body.Append(new Paragraph(new Run(new Text($"Note: {rtbNote.Text}"))));

                mainPart.Document.Append(body);
            }


        }

    }
}
