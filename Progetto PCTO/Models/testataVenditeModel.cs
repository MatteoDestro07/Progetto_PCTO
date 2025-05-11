using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_PCTO.Models
{
    class testataVenditeModel
    {
        private int numeroFattura;
        private int clienteID;
        private DateTime data;
        private string indirizzo;

        public int NumeroFattura { get => numeroFattura; set => numeroFattura = value; }
        public int ClienteID { get => clienteID; set => clienteID = value; }
        public DateTime Data { get => data; set => data = value; }
        public string Indirizzo { get => indirizzo; set => indirizzo = value; }
    }
}
