using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Progetto_PCTO.Views
{
    public partial class FrmStatistiche : Form
    {
        static public string pathDB = Application.StartupPath + "\\DB\\DB_Progetto.mdf";
        string connString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={pathDB};Integrated Security=True";

        public FrmStatistiche()
        {
            InitializeComponent();
        }

        private void FrmStatistiche_Load(object sender, EventArgs e)
        {
            caricaCmbAnni(cmbAnni);
            caricaChartBestSell(crtBestSell);

            cmbAnni.SelectedIndex = 10;
        }

        private void cmbMesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            caricaFatturatoAnnuale();
        }

        private void caricaChartBestSell(Chart crt)
        {
            var prodotti = new Dictionary<int, int>();
            
            using (var conn = new System.Data.SqlClient.SqlConnection(connString))
            {
                conn.Open();
                string query = @"SELECT * FROM DettaglioVendite";

                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idProdotto = reader.GetInt32(2);
                        int quantita = reader.GetInt32(3);

                        if (prodotti.ContainsKey(idProdotto))
                            prodotti[idProdotto] += quantita;
                        else
                            prodotti[idProdotto] = quantita;
                    }

                    reader.Close();
                }

                var top5 = prodotti.OrderByDescending(p => p.Value).Take(5).ToList();

                var prodottiConNome = new List<Tuple<string, int>>();
                foreach (var kvp in top5)
                {
                    string nomeProdotto = "";
                    string queryNome = "SELECT DescrizioneProdotto FROM Prodotti WHERE Id = @idProdotto";
                    using (var cmdNome = new System.Data.SqlClient.SqlCommand(queryNome, conn))
                    {
                        cmdNome.Parameters.AddWithValue("@idProdotto", kvp.Key);
                        var result = cmdNome.ExecuteScalar();
                        if (result != null)
                            nomeProdotto = result.ToString();
                    }
                    prodottiConNome.Add(new Tuple<string, int>(nomeProdotto, kvp.Value));
                }

                crt.Series.Clear();
                var serie = crt.Series.Add("Top 5 Prodotti");
                serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                crt.Legends.Clear();

                foreach (var prodotto in prodottiConNome)
                {
                    serie.Points.AddXY(prodotto.Item1, prodotto.Item2);
                }
            }
        }

        private void caricaFatturatoAnnuale()
        {
            if (cmbAnni.SelectedItem == null)
                return;

            int annoSelezionato;
            if (!int.TryParse(cmbAnni.SelectedItem.ToString(), out annoSelezionato))
                return;

            var fatturatoPerMese = new Dictionary<int, decimal>();

            using (var conn = new System.Data.SqlClient.SqlConnection(connString))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        MONTH(TV.Data) AS Mese,
                        DV.QuantitaVenduta,
                        P.Prezzo
                    FROM 
                        TestataVendite TV
                        INNER JOIN DettaglioVendite DV ON TV.NumeroFattura = DV.NumeroFattura
                        INNER JOIN Prodotti P ON DV.IdProdotto = P.Id
                    WHERE YEAR(TV.Data) = @anno";

                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@anno", annoSelezionato);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int mese = reader.GetInt32(0);
                            int quantita = reader.GetInt32(1);
                            decimal prezzo = reader.GetDecimal(2);
                            decimal totale = quantita * prezzo;

                            if (fatturatoPerMese.ContainsKey(mese))
                                fatturatoPerMese[mese] += totale;
                            else
                                fatturatoPerMese[mese] = totale;
                        }
                    }
                }
            }

            crtFatturato.Series.Clear();
            var serie = crtFatturato.Series.Add("Fatturato Mensile");
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            crtFatturato.Legends.Clear();

            string[] nomiMesi = { "Gen", "Feb", "Mar", "Apr", "Mag", "Giu", "Lug", "Ago", "Set", "Ott", "Nov", "Dic" };

            for (int i = 1; i <= 12; i++)
            {
                decimal valore = fatturatoPerMese.ContainsKey(i) ? fatturatoPerMese[i] : 0;
                serie.Points.AddXY(nomiMesi[i - 1], valore);
            }

            crtFatturato.ChartAreas[0].AxisX.Interval = 1;
        }


        public void caricaCmbAnni(ComboBox cmb)
        {
            cmb.Items.Clear();
            int annoCorrente = DateTime.Now.Year;
            for (int anno = annoCorrente-10; anno <= annoCorrente; anno++)
            {
                cmb.Items.Add(anno.ToString());
            }
        }
    }
}
