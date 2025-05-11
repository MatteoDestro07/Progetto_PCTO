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
    class dettaglioVenditeController
    {
        private adoNetSQL sqlDettaglioVendita;
        private bool pErrore;
        private string pStrSQL;
        private DataTable pTabellaDettaglioVendita;
        private string pRisultato;
        private List<dettaglioVenditeModel> listaDettaglioVendita;

        public dettaglioVenditeModel dettaglioVendita;

        public dettaglioVenditeController()
        {
            string pathDB = Application.StartupPath + "\\DB\\DB_Progetto.mdf";
            sqlDettaglioVendita = new adoNetSQL(pathDB);
            dettaglioVendita = new dettaglioVenditeModel();
        }

        public List<dettaglioVenditeModel> elencoDettaglioVendita()
        {
            listaDettaglioVendita = new List<dettaglioVenditeModel>();
            pStrSQL = @"SELECT * 
                            FROM DettaglioVendite";
            caricaListaDettaglioVendita();
            return listaDettaglioVendita;
        }

        private void eseguiSQL(string tipo)
        {
            int risultato = -1;
            pRisultato = string.Empty;

            try
            {
                if (tipo == "NQRY")
                    risultato = sqlDettaglioVendita.eseguiNonQuery(pStrSQL, CommandType.Text);

                else if (tipo == "QRY")
                    pTabellaDettaglioVendita = sqlDettaglioVendita.eseguiQuery(pStrSQL, CommandType.Text);

                else if (tipo == "SCA")
                    pRisultato = sqlDettaglioVendita.eseguiScalar(pStrSQL, CommandType.Text);
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
                dettaglioVendita.IdDettaglioVendita = CalcolaProssimoId();
                sqlDettaglioVendita.cmd.Parameters.AddWithValue("@IdDettaglioVendita", dettaglioVendita.IdDettaglioVendita);
                sqlDettaglioVendita.cmd.Parameters.AddWithValue("@NumeroFattura", dettaglioVendita.NumeroFattura);
                sqlDettaglioVendita.cmd.Parameters.AddWithValue("@IdProdotto", dettaglioVendita.IdProdotto);
                sqlDettaglioVendita.cmd.Parameters.AddWithValue("@QuantitaVenduta", dettaglioVendita.QuantitaVenduta);
            }
        }

        public int CalcolaProssimoId()
        {
            pStrSQL = "SELECT ISNULL(MAX(IdDettaglioVendita), 0) + 1 AS ProssimoId FROM DettaglioVendite";
            eseguiSQL("SCA");
            if (int.TryParse(pRisultato, out int prossimoId))
            {
                return prossimoId;
            }
            return 0;
        }

        public void aggiungi()
        {
            creaParametriSQL("*ALL");
            pStrSQL = @"INSERT INTO DettaglioVendite 
                            VALUES (@IdDettaglioVendita, @NumeroFattura, @IdProdotto, @QuantitaVenduta)";
            eseguiSQL("NQRY");
        }

        private void caricaListaDettaglioVendita()
        {
            try
            {
                pTabellaDettaglioVendita = sqlDettaglioVendita.eseguiQuery(pStrSQL, CommandType.Text);
                if (pTabellaDettaglioVendita.Rows.Count > 0)
                {
                    for (int i = 0; i < pTabellaDettaglioVendita.Rows.Count; i++)
                    {
                        dettaglioVenditeModel item = new dettaglioVenditeModel();
                        item.IdDettaglioVendita = Convert.ToInt32(pTabellaDettaglioVendita.Rows[i]["IdDettaglioVendita"]);
                        item.NumeroFattura = Convert.ToInt32(pTabellaDettaglioVendita.Rows[i]["NumeroFattura"]);
                        item.IdProdotto = Convert.ToInt32(pTabellaDettaglioVendita.Rows[i]["IdProdotto"]);
                        item.QuantitaVenduta = Convert.ToInt32(pTabellaDettaglioVendita.Rows[i]["QuantitaVenduta"]);
                        listaDettaglioVendita.Add(item);
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
