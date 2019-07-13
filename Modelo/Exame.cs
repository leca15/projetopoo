using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Exame
    {
        public long ExameID { get; set; }
        public string NomeEx { get; set; }
        public string NomeAnimal { get; set; }
        public string NomeDono { get; set; }
        public string CPFDono { get; set; }
        public string Contato { get; set; }
        public DateTime DataRealizacao { get; set; }
        public double ValorEx { get; set; }
        public bool Status { get; set; }

    }
}
