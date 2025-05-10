using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_PCTO.Models
{
    class dettaglioVenditeModel
    {
        private int idDettaglioVendita;
        private int numeroFattura;
        private int idProdotto;
        private int quantitaVenduta;

        public int IdDettaglioVendita { get => idDettaglioVendita; set => idDettaglioVendita = value; }
        public int NumeroFattura { get => numeroFattura; set => numeroFattura = value; }
        public int IdProdotto { get => idProdotto; set => idProdotto = value; }
        public int QuantitaVenduta { get => quantitaVenduta; set => quantitaVenduta = value; }
    }
}
