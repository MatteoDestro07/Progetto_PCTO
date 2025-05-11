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
    class testataVenditeController
    {
        private adoNetSQL sqlTestataVendita;
        private bool pErrore;
        private string pStrSQL;
        private DataTable pTabellaTestataVendita;
        private string pRisultato;
        private List<testataVenditeModel> listaTestataVendita;

        public testataVenditeModel testataVendita;

        public testataVenditeController()
        {
            string pathDB = Application.StartupPath + "\\DB\\DB_Progetto.mdf";
            sqlTestataVendita = new adoNetSQL(pathDB);
            testataVendita = new testataVenditeModel();
        }

        public List<testataVenditeModel> elencoTestataVendita()
        {
            listaTestataVendita = new List<testataVenditeModel>();
            pStrSQL = @"SELECT * 
                                FROM TestataVendite";
            caricaListaTestataVendita();
            return listaTestataVendita;
        }

        private void eseguiSQL(string tipo)
        {
            int risultato = -1;
            pRisultato = string.Empty;

            try
            {
                if (tipo == "NQRY")
                    risultato = sqlTestataVendita.eseguiNonQuery(pStrSQL, CommandType.Text);

                else if (tipo == "QRY")
                    pTabellaTestataVendita = sqlTestataVendita.eseguiQuery(pStrSQL, CommandType.Text);

                else if (tipo == "SCA")
                    pRisultato = sqlTestataVendita.eseguiScalar(pStrSQL, CommandType.Text);
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
                testataVendita.NumeroFattura = CalcolaProssimoNumeroFattura();
                sqlTestataVendita.cmd.Parameters.AddWithValue("@NumeroFattura", testataVendita.NumeroFattura);
                sqlTestataVendita.cmd.Parameters.AddWithValue("@ClienteID", testataVendita.ClienteID);
                sqlTestataVendita.cmd.Parameters.AddWithValue("@Data", testataVendita.Data);
                sqlTestataVendita.cmd.Parameters.AddWithValue("@Indirizzo", testataVendita.Indirizzo);
            }
            else if (tipo == "COD")
            {
                sqlTestataVendita.cmd.Parameters.AddWithValue("@NumeroFattura", testataVendita.NumeroFattura);
            }
            else if (tipo == "MOD")
            {
                sqlTestataVendita.cmd.Parameters.AddWithValue("@NumeroFattura", testataVendita.NumeroFattura);
                sqlTestataVendita.cmd.Parameters.AddWithValue("@Indirizzo", testataVendita.Indirizzo);
            }
        }

        public int CalcolaProssimoNumeroFattura()
        {
            pStrSQL = "SELECT ISNULL(MAX(NumeroFattura), 0) + 1 AS ProssimoNumeroFattura FROM TestataVendite";
            eseguiSQL("SCA");
            if (int.TryParse(pRisultato, out int prossimoNumeroFattura))
            {
                return prossimoNumeroFattura;
            }
            return 0;
        }

        public void aggiungi()
        {
            creaParametriSQL("*ALL");
            pStrSQL = @"INSERT INTO TestataVendite 
                                VALUES (@NumeroFattura, @ClienteID, @Data, @Indirizzo)";
            eseguiSQL("NQRY");
        }

        private void caricaListaTestataVendita()
        {
            try
            {
                pTabellaTestataVendita = sqlTestataVendita.eseguiQuery(pStrSQL, CommandType.Text);
                if (pTabellaTestataVendita.Rows.Count > 0)
                {
                    for (int i = 0; i < pTabellaTestataVendita.Rows.Count; i++)
                    {
                        testataVenditeModel item = new testataVenditeModel();
                        item.NumeroFattura = Convert.ToInt32(pTabellaTestataVendita.Rows[i]["NumeroFattura"]);
                        item.ClienteID = Convert.ToInt32(pTabellaTestataVendita.Rows[i]["ClienteID"]);
                        item.Data = Convert.ToDateTime(pTabellaTestataVendita.Rows[i]["Data"]);
                        item.Indirizzo = pTabellaTestataVendita.Rows[i]["Indirizzo"].ToString();
                        listaTestataVendita.Add(item);
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
