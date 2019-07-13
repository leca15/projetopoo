using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Persistencia;

namespace Servico
{
    public class CaixaServiço
    {
        private CaixaDAL caixaDAL = new CaixaDAL();

        public IList<Caixa> TodosOsRegistros()
        {
            return caixaDAL.TodosOsRegistros();
        }

        public void InserirRegistro(Caixa caixa)
        {
            caixaDAL.InserirRegistro(caixa);
        }

        public List<Caixa> BuscarRegistro(string cpf)
        {
            List<Caixa> caixa = caixaDAL.BuscarRegistros(cpf);
            return caixa;
        }


        public List<Caixa> BuscarPorData(DateTime dataInicio, DateTime dataFim)
        {
            List<Caixa> caixa = caixaDAL.BuscarPorData(dataInicio, dataFim);
            return caixa;
        }
    }
}
