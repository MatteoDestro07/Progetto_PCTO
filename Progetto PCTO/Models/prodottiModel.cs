using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_PCTO.Models
{
    class prodottiModel
    {
        private int idProdotto;
        private int idCategoria;
        private string descProdotto;
        private int quantita;
        private string prezzo;
        private string immagine;
        private char validita;

        public int IdProdotto { get => idProdotto; set => idProdotto = value; }
        public string DescProdotto { get => descProdotto; set => descProdotto = value; }
        public int Quantita { get => quantita; set => quantita = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Prezzo { get => prezzo; set => prezzo = value; }
        public string Immagine { get => immagine; set => immagine = value; }
        public char Validita { get => validita; set => validita = value; }

    }
}
