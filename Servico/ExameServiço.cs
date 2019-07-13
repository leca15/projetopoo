using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Persistencia;

namespace Servico
{
    public class ExameServiço
    {
        private ExameDAL exameDAL = new ExameDAL();

        public IList<Exame> TodosOsExames()
        {
            return exameDAL.TodosOsExames();
        }

        public void MarcarExame(Exame exame)
        {
            exameDAL.MarcarExame(exame);
        }

        public void RemoverExame(long exameID)
        {
            exameDAL.RemoverExame(exameID);
        }

        public List<Exame> BuscarExame(string cpf)
        {
            List<Exame> exame = exameDAL.BuscarExame(cpf);
            return exame;
        }

        public List<Exame> BuscarPorData(DateTime dataInicio, DateTime dataFim)
        {
            List<Exame> exame = exameDAL.BuscarPorData(dataInicio, dataFim);
            return exame;
        }
    }
}
