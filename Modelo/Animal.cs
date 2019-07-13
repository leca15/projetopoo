using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Animal
    {
        public long AnimalID { get; set; }
        public string NomePet { get; set; }
        public string Raça { get; set; }
        public string Porte { get; set; }
        public string IdadePet { get; set; }
        public string NecesPet { get; set; }
        public string CliCPF { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
