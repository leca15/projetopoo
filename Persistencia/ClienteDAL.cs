using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Persistencia
{
    public class ClienteDAL
    {
        //private EFContext context;
        public List<Cliente> TodosOsClientes()
        {
            using (var context = new EFContext())
            {
                return context.Clientes.ToList<Cliente>();
            }
        }

        public void GravarCliente(Cliente cliente)
        {
            using (var context = new EFContext())
            {
                if (cliente.ClienteID > 0) context.Entry(cliente).State = EntityState.Modified;
                else
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }

        public void Remover (long clienteID)
        {
            using (var context = new EFContext())
            {
                var cliente = context.Clientes.Single(d => d.ClienteID == clienteID);
                context.Clientes.Remove(cliente);
                context.SaveChanges();
            }
        }

        public List<Cliente> Buscar(string cpf)
        {
            using (var context = new EFContext())
            {
                return context.Clientes.Where<Cliente>(cliente => cliente.CPFCli == cpf).ToList<Cliente>();
            }
        }
    }
}
