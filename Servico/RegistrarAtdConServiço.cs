using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Persistencia;

namespace Servico
{
    public class RegistrarAtdConServiço
    {
        private RegistrarAtdConsDAL RegAtdCDAL = new RegistrarAtdConsDAL();

        public IList<RegistrarAtdCons> TodosOsRegistros()
        {
            return RegAtdCDAL.TodosOsRegistros();
        }

        public void GravarAtdCons(RegistrarAtdCons registrarAtdCons)
        {
            RegAtdCDAL.GravarAtdCons(registrarAtdCons);
        }

        public void ExcluirAtdCons(long RegAtdConsId)
        {
            RegAtdCDAL.ExcluirAtdCons(RegAtdConsId);
        }

        public List<RegistrarAtdCons> BuscarRegistro(string nome)
        {
            List<RegistrarAtdCons> RegAtdCons = RegAtdCDAL.BuscarRegistro(nome);
            return RegAtdCons;
        }
    }
}
