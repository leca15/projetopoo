using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Persistencia;

namespace Servico
{
    public class ConsultaServiço
    {
        private ConsultaDAL consultaDAL = new ConsultaDAL();

        public IList<Consulta> TodosAsConsultas()
        {
            return consultaDAL.TodosAsConsultas();
        }

        public void MarcarConsulta(Consulta consulta)
        {
            consultaDAL.MarcarConsulta(consulta);
        }

        public void RemoverConsulta(long consultaID)
        {
            consultaDAL.RemoverConsulta(consultaID);
        }

        public List<Consulta> BuscarConsulta(string cpf)
        {
            List<Consulta> consulta = consultaDAL.BuscarConsulta(cpf);
            return consulta;
        }

        public List<Consulta> BuscarPorData(DateTime dataInicio, DateTime dataFim)
        {
            List<Consulta> consultas = consultaDAL.BuscarPorData(dataInicio, dataFim);
            return consultas;
        }
    }
}
