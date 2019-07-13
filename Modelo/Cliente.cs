using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Cliente
    {
        public long ClienteID { get; set; }
        public string NomeCli { get; set; }
        public string ContatoCli { get; set; }
        public string CPFCli { get; set; }
        public string EmailCli { get; set; }
        public string EndereçoCli { get; set; }
        public string CidadeCli { get; set; }
        public long PetID { get; set; }
        public virtual List<Animal> Animal { get; set; }
    }
}
