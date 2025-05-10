using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_PCTO.Models
{
    class carrelloModel
    {
        private int idProdotto;
        private int idCategoria;
        private decimal prezzo;
        private int quantita;

        public int IdProdotto { get => idProdotto; set => idProdotto = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public decimal Prezzo { get => prezzo; set => prezzo = value; }
        public int Quantita { get => quantita; set => quantita = value; }
    }
}
