using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Modelo;


namespace Persistencia
{
    public class AtdAvulsoDAL
    {
        public List<AtdAvulso> TodosOsAtendimentos()
        {
            using (var context = new EFContext())
            {
                return context.AtdAvulso.ToList<AtdAvulso>();
            }
        }

        public void RegistrarAtendimento(AtdAvulso atdAvulso)
        {
            using (var context = new EFContext())
            {
                if (atdAvulso.AtdAvulsoID > 0) context.Entry(atdAvulso).State = EntityState.Modified;
                else
                    context.AtdAvulso.Add(atdAvulso);
                context.SaveChanges();
            }
        }

        public void RemoverAtendimento(long CodAtendimento)
        {
            using (var context = new EFContext())
            {
                var atendimento = context.AtdAvulso.Single(d => d.AtdAvulsoID == CodAtendimento);
                context.AtdAvulso.Remove(atendimento);
                context.SaveChanges();
            }
        }

        public List<AtdAvulso> BuscarAtendimento(string nome)
        {
            using (var context = new EFContext())
            {
                return context.AtdAvulso.Where<AtdAvulso>(AtdAvulso => AtdAvulso.NomeResponsavel == nome).ToList<AtdAvulso>();
            }
        }

        public List<AtdAvulso> BuscarPorData(DateTime dataInicio, DateTime dataFim)
        {
            using (var context = new EFContext())
            {
                return context.AtdAvulso.Where<AtdAvulso>(atend => atend.DataAtendimento.Date >= dataInicio.Date && atend.DataAtendimento.Date <= dataFim.Date).ToList<AtdAvulso>();
            }
        }
    }
}
