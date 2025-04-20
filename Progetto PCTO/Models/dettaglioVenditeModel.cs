using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_PCTO.Models
{
    class dettaglioVenditeModel
    {
        private int idVendita;
        private int idProdotto;
        private string descrizioneProdotto;
        private int quantita;
        private decimal prezzoUnitario;

        public int IdVendita { get => idVendita; set => idVendita = value; }
        public int IdProdotto { get => idProdotto; set => idProdotto = value; }
        public string DescrizioneProdotto { get => descrizioneProdotto; set => descrizioneProdotto = value; }
        public int Quantita { get => quantita; set => quantita = value; }
        public decimal PrezzoUnitario { get => prezzoUnitario; set => prezzoUnitario = value; }
    }
}
