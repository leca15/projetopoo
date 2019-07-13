using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Persistencia
{
    public class ConsultaDAL
    {
        public List<Consulta> TodosAsConsultas()
        {
            using (var context = new EFContext())
            {
                return context.Consultas.ToList<Consulta>();
            }
        }

        public void MarcarConsulta(Consulta consulta)
        {
            using (var context = new EFContext())
            {
                if (consulta.ConsultaID > 0) context.Entry(consulta).State = EntityState.Modified;
                else
                    context.Consultas.Add(consulta);
                context.SaveChanges();
            }
        }

        public void RemoverConsulta(long consultaID)
        {
            using (var context = new EFContext())
            {
                var consulta = context.Consultas.Single(d => d.ConsultaID == consultaID);
                context.Consultas.Remove(consulta);
                context.SaveChanges();
            }
        }

        public List<Consulta> BuscarConsulta(string cpf)
        {
            using (var context = new EFContext())
            {
                return context.Consultas.Where<Consulta>(consulta => consulta.CPFDono == cpf).ToList<Consulta>();
            }
        }

        public List<Consulta> BuscarPorData(DateTime dataInicio, DateTime dataFim)
        {
            using (var context = new EFContext())
            {
                return context.Consultas.Where<Consulta>(consulta => consulta.DataCons.Date >= dataInicio.Date && consulta.DataCons.Date <= dataFim.Date).ToList<Consulta>();
            }
        }
    }
}
