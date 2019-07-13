using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using System.Linq;
using Persistencia;

namespace Servico
{
    public class ClienteServiço
    {
        private ClienteDAL clienteDAL = new ClienteDAL();
        public IList<Cliente> TodosOsClientes()
        {
            return clienteDAL.TodosOsClientes();
        }

        public void GravarCliente(Cliente cliente)
        {
            clienteDAL.GravarCliente(cliente);
        }

        public void Remover(long clienteID)
        {
            clienteDAL.Remover(clienteID);
        }

        public List<Cliente> Buscar(string cpf)
        {
            List<Cliente> clientes = clienteDAL.Buscar(cpf);
            return clientes;
        }
    }
}
