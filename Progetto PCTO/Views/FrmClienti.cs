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
        public string modalita = string.Empty;

        public FrmClienti() 
        {
            InitializeComponent();
        }

        private void FrmClienti_Load(object sender, EventArgs e)
        {
            visElencoClienti();
            rbAggiungiCliente.Checked = true;
            caricaCmb(cmbModificaId);
            caricaCmb(cmbEliminaCliente);
        }

        private void caricaCmb(ComboBox cmb)
        {
            cmb.Items.Clear();
            clientiController clientiController = new clientiController();
            List<clientiModel> listaClienti = clientiController.elencoClienti();
            foreach (var cliente in listaClienti)
            {
                if(cliente.Validita == ' ')
                    cmb.Items.Add(cliente.IdCliente);
            }
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
            clientiController listaClienti = new clientiController();

            dgvClienti.DataSource = null;

            caricaClienti(listaClienti.elencoClienti());

        }

        private void caricaClienti(List<clientiModel> lista)
        {
            dgvClienti.DataSource = lista;
            dgvClienti.ReadOnly = true;
            dgvClienti.Columns["Validita"].Visible = false;
            dgvClienti.ClearSelection();
        }

        private void btnAggiungiModificaElimina_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty)
                if (txtCognome.Text != string.Empty)
                    if (!string.IsNullOrEmpty(txtEmail.Text) && chkEmail(txtEmail.Text) && chkEmailDoppia(txtEmail.Text))
                    {
                        clientiController clienti = new clientiController();
                        clienti.clienti.Nome = txtNome.Text;
                        clienti.clienti.Cognome = txtCognome.Text;
                        clienti.clienti.Email = txtEmail.Text;
                        clienti.clienti.Validita = ' ';
                        clienti.aggiungi();
                        visElencoClienti();
                        caricaCmb(cmbModificaId);
                        caricaCmb(cmbEliminaCliente);
                    }
                    else
                    {
                        MessageBox.Show("Email non valida o è già presente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail.Focus();
                    }
                else
                {
                    MessageBox.Show("Cognome non valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCognome.Focus();
                }
            else
            {
                MessageBox.Show("Nome non valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
            }
        }

        private void btnModificaCliente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomeModifica.Text))
            {
                if (!string.IsNullOrEmpty(txtCognomeModifica.Text))
                {
                    if (!string.IsNullOrEmpty(txtEmailModifica.Text) && chkEmail(txtEmailModifica.Text))
                    {
                        try
                        {
                            clientiController clienti = new clientiController();
                            clienti.clienti.IdCliente = Convert.ToInt32(cmbModificaId.SelectedItem);
                            clienti.clienti.Nome = txtNomeModifica.Text;
                            clienti.clienti.Cognome = txtCognomeModifica.Text;
                            clienti.clienti.Email = txtEmailModifica.Text;
                            clienti.modifica();
                            visElencoClienti();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Errore durante la modifica del cliente: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email non valida", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmailModifica.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Cognome non valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCognomeModifica.Focus();
                }
            }
            else
            {
                MessageBox.Show("Nome non valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeModifica.Focus();
            }
        }

        private bool chkEmailDoppia(string email)
        {
            clientiController clienti = new clientiController();
            List<clientiModel> listaClienti = clienti.elencoClienti();
            foreach (var cliente in listaClienti)
            {
                if (cliente.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && cliente.IdCliente != Convert.ToInt32(cmbModificaId.SelectedItem))
                {
                    return false;
                }
            }
            return true;
        }

        private bool chkEmail(string email)
        {
            if (email.Contains("@") && email.Contains("."))
                return true;
            else
                return false;
        }

        private void rbAggiungiCliente_CheckedChanged(object sender, EventArgs e)
        {
            controllaChk();
        }

        private void rbModificaCliente_CheckedChanged(object sender, EventArgs e)
        {
            controllaChk();
        }

        private void rbEliminaCliente_CheckedChanged(object sender, EventArgs e)
        {
            controllaChk();
        }

        public void controllaChk()
        {
            if (rbAggiungiCliente.Checked)
            {
                grbAggiungiModificaEliminaClienti.Visible = true;
                grbModificaCliente.Visible = false;
                grbEliminaCliente.Visible = false;
            }
            else if (rbModificaCliente.Checked)
            {
                grbAggiungiModificaEliminaClienti.Visible = false;
                grbModificaCliente.Visible = true;
                grbEliminaCliente.Visible = false;
            }
            else if (rbEliminaCliente.Checked)
            {
                grbAggiungiModificaEliminaClienti.Visible = false;
                grbModificaCliente.Visible = false;
                grbEliminaCliente.Visible = true;
            }
        }

        private void cmbModificaId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idClienteSelezionato = Convert.ToInt32(cmbModificaId.SelectedItem);
            clientiController clienti = new clientiController();
            clientiModel clienteSelezionato = clienti.elencoClienti().FirstOrDefault(c => c.IdCliente == idClienteSelezionato);

            if (clienteSelezionato != null)
            {
                txtNomeModifica.Text = clienteSelezionato.Nome;
                txtCognomeModifica.Text = clienteSelezionato.Cognome;
                txtEmailModifica.Text = clienteSelezionato.Email;
            }
        }

        private void btnEliminaCliente_Click(object sender, EventArgs e)
        {
            clientiController clienti = new clientiController();
            clienti.clienti.IdCliente = Convert.ToInt32(cmbEliminaCliente.SelectedItem);
            clienti.elimina();
            visElencoClienti();
            caricaCmb(cmbModificaId);
            caricaCmb(cmbEliminaCliente);
        }
    }
}
