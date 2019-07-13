using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class AtdAvulso
    {
        public long AtdAvulsoID { get; set; }
        public string NomeResponsavel { get; set; }
        public string CPFResp { get; set; }
        public string ContatoResp { get; set; }
        public string NomeAnimal { get; set; }
        public string Raça { get; set; }
        public string Porte { get; set; }
        public string NomeServ { get; set; }
        public double PreçoServ { get; set; }
        public string Remedios { get; set; }
        public DateTime DataAtendimento { get; set; }
    }
}
