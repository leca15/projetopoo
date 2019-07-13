using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Caixa
    {
        public long CaixaID { get; set; }
        public string CPFCliente { get; set; }
        public DateTime DataCons { get; set; }
        public double ValorCons { get; set; }
        public bool Status { get; set; }
        public string Procedencia { get; set; }
    }
}
