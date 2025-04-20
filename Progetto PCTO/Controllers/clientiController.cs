using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using Progetto_PCTO.Models;

namespace Progetto_PCTO.Controllers
{
    class clientiController
    {
        private adoNetSQL sqlClienti;
        private bool pErrore;
        private string pStrSQL;
        private string pMsgRisultato;
        private DataTable pTabellaClienti;
        private string pRisultato;
        private List<clientiModel> listaClienti;

        public clientiModel clienti;
        public string msgRitorno;

        public clientiController()
        {
            string pathDB = Application.StartupPath + "\\DB\\DB_Progetto.mdf";
            sqlClienti = new adoNetSQL(pathDB);
            clienti = new clientiModel();
            clienti.Validita = ' ';
            msgRitorno = string.Empty;
        }

        public List<clientiModel> elencoClienti()
        {

            listaClienti = new List<clientiModel>();

            pStrSQL = @"SELECT * 
                          FROM Clienti 
                            WHERE Validita = ' ' ";

            pMsgRisultato = "Lista Aziende creata con successo !!!";
            caricaListaClienti();

            return listaClienti;
        }

        private void eseguiSQL(string tipo)
        {

            int risultato = -1;

            pRisultato = string.Empty;


            try
            {
                if (tipo == "NQRY")
                    risultato = sqlClienti.eseguiNonQuery(pStrSQL, CommandType.Text);

                else if (tipo == "QRY")
                    pTabellaClienti = sqlClienti.eseguiQuery(pStrSQL, CommandType.Text);

                else if (tipo == "SCA")
                    pRisultato = sqlClienti.eseguiScalar(pStrSQL, CommandType.Text);

            }
            catch (Exception ex)
            {
                msgRitorno = ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    msgRitorno = pMsgRisultato;
            }

        }

        private void caricaListaClienti()
        {

            SqlDataReader dataReader;
            pErrore = false;

            try
            {

                dataReader = sqlClienti.creaLettore(pStrSQL, CommandType.Text);
                while (dataReader.Read())
                {
                    clientiModel detCliente = new clientiModel();
                    detCliente.IdCliente = Convert.ToInt32(dataReader["Id"]);
                    detCliente.Nome = dataReader["Nome"].ToString();
                    detCliente.Cognome = dataReader["Cognome"].ToString();
                    detCliente.Email = dataReader["Email"].ToString();
                    detCliente.Validita = Convert.ToChar(dataReader["Validita"].ToString());
                    listaClienti.Add(detCliente);
                }

            }
            catch (Exception ex)
            {
                msgRitorno = ex.Message;
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                {
                    msgRitorno = pMsgRisultato;
                    sqlClienti.chiudiLettore();
                }
            }
        }
    }
}
