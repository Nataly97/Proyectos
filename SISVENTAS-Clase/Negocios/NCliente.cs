using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;


namespace Negocios
{
    public class NCliente
    {
        DCliente objCliente = new DCliente();
        public DataTable listaDeClientes()
        {
            return objCliente.listaClientes();
        }

        public bool registroCliente(DCliente cliente)
        {
            return objCliente.registrarCliente(cliente);
        }

        public DataTable TablaClientes()
        {
            return objCliente.listarClientes();
        }

        public bool EliminarCliente(int id)
        {
            return objCliente.eliminarCliente(id);
        }

        public bool EditarCliente(DCliente cliente)
        {
            return objCliente.editarCliente(cliente);
        }
    }
}
