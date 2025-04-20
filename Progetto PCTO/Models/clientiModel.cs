using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_PCTO.Models
{
    class clientiModel
    {
        private int idCliente;
        private string nome;
        private string cognome;
        private string email;
        private char validita;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Email { get => email; set => email = value; }
        public char Validita { get => validita; set => validita = value; }
    }
}
