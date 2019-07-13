using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Persistencia
{
    public class ExameDAL
    {
        public List<Exame> TodosOsExames()
        {
            using (var context = new EFContext())
            {
                return context.Exames.ToList<Exame>();
            }
        }

        public void MarcarExame(Exame exame)
        {
            using (var context = new EFContext())
            {
                if (exame.ExameID > 0) context.Entry(exame).State = EntityState.Modified;
                else
                    context.Exames.Add(exame);
                context.SaveChanges();
            }
        }

        public void RemoverExame(long exameID)
        {
            using (var context = new EFContext())
            {
                var exame = context.Exames.Single(d => d.ExameID == exameID);
                context.Exames.Remove(exame);
                context.SaveChanges();
            }
        }

        public List<Exame> BuscarExame(string cpf)
        {
            using (var context = new EFContext())
            {
                return context.Exames.Where<Exame>(exame => exame.CPFDono == cpf).ToList<Exame>();
            }
        }

        public List<Exame> BuscarPorData(DateTime dataInicio, DateTime dataFim)
        {
            using (var context = new EFContext())
            {
                return context.Exames.Where<Exame>(exame => exame.DataRealizacao.Date >= dataInicio.Date && exame.DataRealizacao.Date <= dataFim.Date).ToList<Exame>();
            }
        }
    }
}
