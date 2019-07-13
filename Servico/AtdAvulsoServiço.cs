using System;
using System.Collections.Generic;
using System.Text;
using Persistencia;
using Modelo;

namespace Servico
{
    public class AtdAvulsoServiço
    {
        private AtdAvulsoDAL atdAvulsoDAL = new AtdAvulsoDAL();

        public IList<AtdAvulso> TodosOsAtendimentos()
        {
            return atdAvulsoDAL.TodosOsAtendimentos();
        }

        public void RegistrarAtendimento(AtdAvulso atdAvulso)
        {
            atdAvulsoDAL.RegistrarAtendimento(atdAvulso);
        }

        public void RemoverAtendimento(long atdAvulsoId)
        {
            atdAvulsoDAL.RemoverAtendimento(atdAvulsoId);
        }

        public List<AtdAvulso> BuscarAtendimento(string nome)
        {
            List<AtdAvulso> atdAvulso = atdAvulsoDAL.BuscarAtendimento(nome);
            return atdAvulso;
        }

        public List<AtdAvulso> BuscarPorData(DateTime dataInicio, DateTime dataFim)
        {
            List<AtdAvulso> atend = atdAvulsoDAL.BuscarPorData(dataInicio, dataFim);
            return atend;
        }
    }
}
