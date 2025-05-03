using Progetto_PCTO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.SqlClient;

namespace Progetto_PCTO.Controllers
{
    class categorieController
    {
        private adoNetSQL sqlCategorie;
        private bool pErrore;
        private string pStrSQL;
        private DataTable pTabellaCategorie;
        private string pRisultato;
        private List<categorieModel> listaCategorie;

        public categorieModel categorie;

        public categorieController()
        {
            string pathDB = Application.StartupPath + "\\DB\\DB_Progetto.mdf";
            sqlCategorie = new adoNetSQL(pathDB);
            categorie = new categorieModel();
            categorie.Validita = ' ';
        }

        public List<categorieModel> elencoCategorie()
        {
            listaCategorie = new List<categorieModel>();
            pStrSQL = @"SELECT * 
                          FROM Categorie 
                            WHERE Validita = ' ' ";
            caricaListaCategorie();
            return listaCategorie;
        }

        private void eseguiSQL(string tipo)
        {

            int risultato = -1;

            pRisultato = string.Empty;


            try
            {
                if (tipo == "NQRY")
                    risultato = sqlCategorie.eseguiNonQuery(pStrSQL, CommandType.Text);

                else if (tipo == "QRY")
                    pTabellaCategorie = sqlCategorie.eseguiQuery(pStrSQL, CommandType.Text);

                else if (tipo == "SCA")
                    pRisultato = sqlCategorie.eseguiScalar(pStrSQL, CommandType.Text);

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
                categorie.IdCategoria = CalcolaProssimoId();
                sqlCategorie.cmd.Parameters.AddWithValue("@IdCategoria", categorie.IdCategoria);
                sqlCategorie.cmd.Parameters.AddWithValue("@DescCategoria", categorie.DescCategoria);
                sqlCategorie.cmd.Parameters.AddWithValue("@Validita", categorie.Validita);
            }
            else if (tipo == "COD")
            {
                sqlCategorie.cmd.Parameters.AddWithValue("@IdCategoria", categorie.IdCategoria);
            }
            else if (tipo == "MOD")
            {
                sqlCategorie.cmd.Parameters.AddWithValue("@IdCategoria", categorie.IdCategoria);
                sqlCategorie.cmd.Parameters.AddWithValue("@DescCategoria", categorie.DescCategoria);
                sqlCategorie.cmd.Parameters.AddWithValue("@Validita", categorie.Validita);
            }
        }

        public int CalcolaProssimoId()
        {
            pStrSQL = "SELECT ISNULL(MAX(Id), 0) + 1 AS ProssimoId FROM Categorie";
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
            pStrSQL = @"INSERT INTO Categorie 
                        VALUES (@IdCategoria,@DescCategoria, @Validita)";
            eseguiSQL("NQRY");
            MessageBox.Show("Categoria aggiunta con successo !!!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void modifica()
        {
            creaParametriSQL("MOD");
            pStrSQL = @"UPDATE Categorie SET 
                        Descrizione = @DescCategoria
                        WHERE Id = @IdCategoria";
            eseguiSQL("NQRY");
            MessageBox.Show("Categoria modificata con successo !!!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void elimina()
        {
            creaParametriSQL("COD");
            pStrSQL = @"UPDATE Categorie SET 
                        Validita = 'X'
                        WHERE Id = @IdCategoria";
            eseguiSQL("NQRY");
            MessageBox.Show("Categoria eliminata con successo !!!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void caricaListaCategorie()
        {
            try
            {
                pTabellaCategorie = sqlCategorie.eseguiQuery(pStrSQL, CommandType.Text);
                if (pTabellaCategorie.Rows.Count > 0)
                {
                    for (int i = 0; i < pTabellaCategorie.Rows.Count; i++)
                    {
                        categorieModel cat = new categorieModel();
                        cat.IdCategoria = Convert.ToInt32(pTabellaCategorie.Rows[i]["Id"]);
                        cat.DescCategoria = pTabellaCategorie.Rows[i]["Descrizione"].ToString();
                        cat.Validita = Convert.ToChar(pTabellaCategorie.Rows[i]["Validita"]);
                        listaCategorie.Add(cat);
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
