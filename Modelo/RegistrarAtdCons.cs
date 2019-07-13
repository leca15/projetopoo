using System;
using System.Collections.Generic;
using System.Text;
namespace Modelo
{
    public class RegistrarAtdCons
    {
        public long RegistrarAtdConsID { get; set; }
        public long ConsultaId { get; set; }
        public string NomeResponsavel { get; set; }
        public string CPFResponsavel { get; set; }
        public string ContResponsavel { get; set; }
        public string NomeAnimal { get; set; }
        public string Raça { get; set; }
        public string Porte { get; set; }
        public DateTime DataConsula { get; set; }
        public string HoraConsulta { get; set; }
        public string DescAtd { get; set; }
        public string Receita { get; set; }
        public double ValorConsulta { get; set; }
        public Consulta Consulta { get; set; }

    }
}
