using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Persistencia
{
    public class RegistrarAtdConsDAL
    {
        public List<RegistrarAtdCons> TodosOsRegistros()
        {
            using (var context = new EFContext())
            {
                return context.RegAtdCons.ToList<RegistrarAtdCons>();
            }
        }

        public void GravarAtdCons(RegistrarAtdCons registrarAtdCons)
        {
            using (var context = new EFContext())
            {
                if (registrarAtdCons.RegistrarAtdConsID > 0) context.Entry(registrarAtdCons).State = EntityState.Modified;
                else
                    context.RegAtdCons.Add(registrarAtdCons);
                context.SaveChanges();
            }
        }

        public void ExcluirAtdCons(long CodAtendimento)
        {
            using (var context = new EFContext())
            {
                var atd = context.RegAtdCons.Single(d => d.RegistrarAtdConsID == CodAtendimento);
                context.RegAtdCons.Remove(atd);
                context.SaveChanges();
            }
        }

        public List<RegistrarAtdCons> BuscarRegistro(string nome)
        {
            using (var context = new EFContext())
            {
                
                return context.RegAtdCons.Where<RegistrarAtdCons>(RegistrarAtdCons => RegistrarAtdCons.NomeResponsavel == nome).ToList<RegistrarAtdCons>();
            }
        }
    }
}
