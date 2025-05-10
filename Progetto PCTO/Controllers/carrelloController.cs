using Progetto_PCTO.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_PCTO.Controllers
{
    class carrelloController
    {
        private adoNetSQL sqlCarrello;
        private bool pErrore;
        private string pStrSQL;
        private DataTable pTabellaCarrello;
        private string pRisultato;
        private List<carrelloModel> listaCarrello;

        public carrelloModel carrello;

        public carrelloController()
        {
            string pathDB = Application.StartupPath + "\\DB\\DB_Progetto.mdf";
            sqlCarrello = new adoNetSQL(pathDB);
            carrello = new carrelloModel();
        }

        public List<carrelloModel> elencoCarrello()
        {
            listaCarrello = new List<carrelloModel>();
            pStrSQL = @"SELECT * 
                              FROM Carrello";
            caricaListaCarrello();
            return listaCarrello;
        }

        private void eseguiSQL(string tipo)
        {
            int risultato = -1;
            pRisultato = string.Empty;

            try
            {
                if (tipo == "NQRY")
                    risultato = sqlCarrello.eseguiNonQuery(pStrSQL, CommandType.Text);

                else if (tipo == "QRY")
                    pTabellaCarrello = sqlCarrello.eseguiQuery(pStrSQL, CommandType.Text);

                else if (tipo == "SCA")
                    pRisultato = sqlCarrello.eseguiScalar(pStrSQL, CommandType.Text);
            }
            catch (Exception)
            {
                pErrore = true;
            }
        }

        private void creaParametriSQL(string tipo)
        {
            if (tipo == "*ALL")
            {
                sqlCarrello.cmd.Parameters.AddWithValue("@IdProdotto", carrello.IdProdotto);
                sqlCarrello.cmd.Parameters.AddWithValue("@IdCategoria", carrello.IdCategoria);
                sqlCarrello.cmd.Parameters.AddWithValue("@Prezzo", carrello.Prezzo);
                sqlCarrello.cmd.Parameters.AddWithValue("@Quantita", carrello.Quantita);
            }
            else if (tipo == "COD")
            {
                sqlCarrello.cmd.Parameters.AddWithValue("@IdProdotto", carrello.IdProdotto);
            }
            else if (tipo == "MOD")
            {
                sqlCarrello.cmd.Parameters.AddWithValue("@IdProdotto", carrello.IdProdotto);
                sqlCarrello.cmd.Parameters.AddWithValue("@Prezzo", carrello.Prezzo);
                sqlCarrello.cmd.Parameters.AddWithValue("@Quantita", carrello.Quantita);
            }
        }

        public void aggiungi()
        {
            creaParametriSQL("*ALL");
            pStrSQL = @"INSERT INTO Carrello 
                            VALUES (@IdProdotto, @IdCategoria, @Prezzo, @Quantita)";
            eseguiSQL("NQRY");
            MessageBox.Show("Prodotto aggiunto al carrello con successo !!!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void modifica()
        {
            creaParametriSQL("MOD");
            pStrSQL = @"UPDATE Carrello SET 
                            Prezzo = @Prezzo,
                            Quantita = @Quantita
                            WHERE IdProdotto = @IdProdotto";
            eseguiSQL("NQRY");
            MessageBox.Show("Prodotto modificato nel carrello con successo !!!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void elimina()
        {
            creaParametriSQL("COD");
            pStrSQL = @"DELETE FROM Carrello 
                            WHERE IdProdotto = @IdProdotto";
            eseguiSQL("NQRY");
            MessageBox.Show("Prodotto rimosso dal carrello con successo !!!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void svuotaCarrello()
        {
            pStrSQL = @"DELETE FROM Carrello";
            eseguiSQL("NQRY");
            MessageBox.Show("Carrello svuotato con successo !!!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void caricaListaCarrello()
        {
            try
            {
                pTabellaCarrello = sqlCarrello.eseguiQuery(pStrSQL, CommandType.Text);
                if (pTabellaCarrello.Rows.Count > 0)
                {
                    for (int i = 0; i < pTabellaCarrello.Rows.Count; i++)
                    {
                        carrelloModel item = new carrelloModel();
                        item.IdProdotto = Convert.ToInt32(pTabellaCarrello.Rows[i]["IdProdotto"]);
                        item.IdCategoria = Convert.ToInt32(pTabellaCarrello.Rows[i]["IdCategoriaProdotto"]);
                        item.Prezzo = Convert.ToDecimal(pTabellaCarrello.Rows[i]["Prezzo"]);
                        item.Quantita = Convert.ToInt32(pTabellaCarrello.Rows[i]["Quantita"]);
                        listaCarrello.Add(item);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
