using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_PCTO.Models
{
    class categorieModel
    {
        private int idCategoria;
        private string descCategoria;
        private char validita;

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string DescCategoria { get => descCategoria; set => descCategoria = value; }
        public char Validita { get => validita; set => validita = value; }
    }
}
