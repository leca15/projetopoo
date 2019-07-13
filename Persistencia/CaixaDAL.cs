using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Persistencia
{
    public class CaixaDAL
    {
        Caixa caixa = new Caixa();

        public List<Caixa> TodosOsRegistros()
        {
            using (var context = new EFContext())
            {
                return context.Caixa.ToList<Caixa>();
            }
        }

        public void InserirRegistro(Caixa caixa)
        {
            using (var context = new EFContext())
            {
                if (caixa.CaixaID > 0) context.Entry(caixa).State = EntityState.Modified;
                else
                    context.Caixa.Add(caixa);
                context.SaveChanges();
            }
        }

        public List<Caixa> BuscarRegistros(string cpf)
        {
            using (var context = new EFContext())
            {
                return context.Caixa.Where<Caixa>(caixa => caixa.CPFCliente == cpf).ToList<Caixa>();
            }
        }

        public List<Caixa> BuscarPorData(DateTime dataInicio, DateTime dataFim)
        {
            using (var context = new EFContext())
            {
                return context.Caixa.Where<Caixa>(caixa => caixa.DataCons.Date >= dataInicio.Date && caixa.DataCons.Date <= dataFim.Date).ToList<Caixa>();
            }
        }

    }
}
