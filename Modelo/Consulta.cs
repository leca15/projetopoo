using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Consulta
    {
        public long ConsultaID { get; set; }
        public string NomeDono { get; set; }
        public string CPFDono { get; set; }
        public string Contato { get; set; }
        public string NomePet { get; set; }
        public string RaçaPet { get; set; }
        public string PortePet { get; set; }
        public double ValorTotal { get; set; }
        public DateTime DataCons { get; set; }
        public string HoraCons { get; set; }

        
    }
}
