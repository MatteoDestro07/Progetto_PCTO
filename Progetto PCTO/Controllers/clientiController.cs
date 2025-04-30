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
        private DataTable pTabellaClienti;
        private string pRisultato;
        private List<clientiModel> listaClienti;

        public clientiModel clienti;

        public clientiController()
        {
            string pathDB = Application.StartupPath + "\\DB\\DB_Progetto.mdf";
            sqlClienti = new adoNetSQL(pathDB);
            clienti = new clientiModel();
            clienti.Validita = ' ';
        }

        public List<clientiModel> elencoClienti()
        {

            listaClienti = new List<clientiModel>();

            pStrSQL = @"SELECT * 
                          FROM Clienti 
                            WHERE Validita = ' ' ";

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
            catch (Exception)
            {
                pErrore = true;
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
            catch (Exception)
            {
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                    sqlClienti.chiudiLettore();
            }
        }

        private void creaParametriSQL(string tipo)
        {
            if (tipo == "*ALL")
            {
                clienti.IdCliente = CalcolaProssimoId();
                sqlClienti.cmd.Parameters.AddWithValue("@IdCliente", clienti.IdCliente);
                sqlClienti.cmd.Parameters.AddWithValue("@NmCliente", clienti.Nome);
                sqlClienti.cmd.Parameters.AddWithValue("@CgCliente", clienti.Cognome);
                sqlClienti.cmd.Parameters.AddWithValue("@EmailCliente", clienti.Email);
                sqlClienti.cmd.Parameters.AddWithValue("@VlCliente", clienti.Validita);
            }
            else if (tipo == "COD")
            {
                sqlClienti.cmd.Parameters.AddWithValue("@IdCliente", clienti.IdCliente);
            }
            else if(tipo == "MOD")
            {
                sqlClienti.cmd.Parameters.AddWithValue("@IdCliente", clienti.IdCliente);
                sqlClienti.cmd.Parameters.AddWithValue("@NmCliente", clienti.Nome);
                sqlClienti.cmd.Parameters.AddWithValue("@CgCliente", clienti.Cognome);
                sqlClienti.cmd.Parameters.AddWithValue("@EmailCliente", clienti.Email);
            }
        }

        public int CalcolaProssimoId()
        {
            pStrSQL = "SELECT ISNULL(MAX(Id), 0) + 1 AS ProssimoId FROM Clienti";
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
            pStrSQL = @"INSERT INTO Clienti 
                        VALUES (@IdCliente,@NmCliente, @CgCliente, @EmailCliente, @VlCliente)";

            eseguiSQL("NQRY");
            MessageBox.Show("Cliente aggiunto con successo !!!","Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void modifica()
        {
            creaParametriSQL("MOD");

            pStrSQL = @"UPDATE Clienti SET 
                        Nome = @NmCliente, Cognome = @CgCliente, Email = @EmailCliente
                        WHERE Id = @IdCliente";

            eseguiSQL("NQRY");

            if (!pErrore)
                MessageBox.Show("Cliente modificato con successo !!!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Errore durante la modifica del cliente.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void elimina()
        {
            creaParametriSQL("COD");

            pStrSQL = @"UPDATE Clienti SET 
                        Validita = 'X'
                        WHERE Id = @IdCliente";

            eseguiSQL("NQRY");
            MessageBox.Show("Cliente eliminato con successo !!!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
