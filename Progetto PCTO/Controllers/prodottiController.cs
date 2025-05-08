using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Progetto_PCTO.Models;
using Progetto_PCTO.Views;
using Progetto_PCTO.Controllers;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace Progetto_PCTO.Controllers
{
    class prodottiController
    {
        private adoNetSQL sqlProdotti;
        private bool pErrore;
        private string pStrSQL;
        private DataTable pTabellaProdotti;
        private string pRisultato;
        private List<prodottiModel> listaProdotti;

        public prodottiModel prodotti;

        public prodottiController()
        {
            string pathDB = Application.StartupPath + "\\DB\\DB_Progetto.mdf";
            sqlProdotti = new adoNetSQL(pathDB);
            prodotti = new prodottiModel();
            prodotti.Validita = ' ';
        }

        public List<prodottiModel> elencoProdotti()
        {
            listaProdotti = new List<prodottiModel>();
            pStrSQL = @"SELECT * 
                          FROM Prodotti  
                            WHERE Validita = ' ' ";
            caricaListaProdotti();
            return listaProdotti;
        }

        private void eseguiSQL(string tipo)
        {

            int risultato = -1;

            pRisultato = string.Empty;


            try
            {
                if (tipo == "NQRY")
                    risultato = sqlProdotti.eseguiNonQuery(pStrSQL, CommandType.Text);

                else if (tipo == "QRY")
                    pTabellaProdotti = sqlProdotti.eseguiQuery(pStrSQL, CommandType.Text);

                else if (tipo == "SCA")
                    pRisultato = sqlProdotti.eseguiScalar(pStrSQL, CommandType.Text);

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
                prodotti.IdProdotto = CalcolaProssimoId();
                sqlProdotti.cmd.Parameters.AddWithValue("@IdProdotti", prodotti.IdProdotto);
                sqlProdotti.cmd.Parameters.AddWithValue("@IdCategoria", prodotti.IdCategoria);
                sqlProdotti.cmd.Parameters.AddWithValue("@DescProdotti", prodotti.DescProdotto);
                sqlProdotti.cmd.Parameters.AddWithValue("@Quantita", prodotti.Quantita);
                sqlProdotti.cmd.Parameters.AddWithValue("@Prezzo", prodotti.Prezzo);
                sqlProdotti.cmd.Parameters.AddWithValue("@Immagine", prodotti.Immagine);
                sqlProdotti.cmd.Parameters.AddWithValue("@Validita", prodotti.Validita);
            }
            else if (tipo == "MOD")
            {
                sqlProdotti.cmd.Parameters.AddWithValue("@IdProdotti", prodotti.IdProdotto);
                sqlProdotti.cmd.Parameters.AddWithValue("@IdCategoria", prodotti.IdCategoria);
                sqlProdotti.cmd.Parameters.AddWithValue("@DescProdotti", prodotti.DescProdotto);
                sqlProdotti.cmd.Parameters.AddWithValue("@Quantita", prodotti.Quantita);
                sqlProdotti.cmd.Parameters.AddWithValue("@Prezzo", prodotti.Prezzo);
                sqlProdotti.cmd.Parameters.AddWithValue("@Immagine", prodotti.Immagine);
                sqlProdotti.cmd.Parameters.AddWithValue("@Validita", prodotti.Validita);
            }
            else if (tipo == "COD")
            {
                sqlProdotti.cmd.Parameters.AddWithValue("@IdProdotti", prodotti.IdProdotto);
            }
        }

        public int CalcolaProssimoId()
        {
            pStrSQL = "SELECT ISNULL(MAX(Id), 0) + 1 AS ProssimoId FROM Prodotti";
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
            pStrSQL = @"INSERT INTO Prodotti 
                        (Id, IdCategoria, DescrizioneProdotto, Quantita, Prezzo, Immagine, Validita) 
                        VALUES (@IdProdotti, @IdCategoria, @DescProdotti, @Quantita, @Prezzo, @Immagine, @Validita)";
            eseguiSQL("NQRY");
            MessageBox.Show("Prodotto aggiunto con successo !!!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void modifica()
        {
            creaParametriSQL("MOD");
            pStrSQL = @"UPDATE Prodotti SET 
                        IdCategoria = @IdCategoria,
                        DescrizioneProdotto = @DescProdotti,
                        Quantita = @Quantita,
                        Prezzo = @Prezzo,
                        Immagine = @Immagine
                       WHERE Id = @IdProdotti";
            eseguiSQL("NQRY");
            MessageBox.Show("Prodotto modificato con successo !!!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void elimina()
        {
            creaParametriSQL("COD");
            pStrSQL = @"UPDATE Prodotti SET 
                        Validita = 'X'
                        WHERE Id = @IdProdotti";
            eseguiSQL("NQRY");
            MessageBox.Show("Prodotto eliminato con successo !!!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void caricaListaProdotti()
        {
            SqlDataReader dataReader;
            pErrore = false;

            try
            {
                dataReader = sqlProdotti.creaLettore(pStrSQL, CommandType.Text);
                while (dataReader.Read())
                {
                    prodottiModel detProdotto = new prodottiModel();
                    detProdotto.IdProdotto = Convert.ToInt32(dataReader["Id"]);
                    detProdotto.IdCategoria = Convert.ToInt32(dataReader["IdCategoria"]);
                    detProdotto.DescProdotto = dataReader["DescrizioneProdotto"].ToString();
                    detProdotto.Quantita = Convert.ToInt32(dataReader["Quantita"]);
                    detProdotto.Prezzo = dataReader["Prezzo"].ToString();
                    detProdotto.Immagine = dataReader["Immagine"].ToString();
                    detProdotto.Validita = Convert.ToChar(dataReader["Validita"]);
                    listaProdotti.Add(detProdotto);
                }
            }
            catch (Exception)
            {
                pErrore = true;
            }
            finally
            {
                if (!pErrore)
                {
                    sqlProdotti.chiudiLettore();
                }
            }
        }

        public string getImg(int id)
        {
            pStrSQL = $"SELECT Immagine FROM Prodotti WHERE Id = {id}";
            eseguiSQL("SCA");
            return pRisultato;
        }
    }
}
