using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;//Se agrega
using System.Data; //Se agrega 

namespace Negocios
{
    public class NProducto
    {
        DProducto objProducto = new DProducto();
        public DataTable ListaDeProductos()
        {
            return objProducto.ListaProductos();
        }

        public string getPrecioProducto(int id)
        {
            return objProducto.preciProducto(id);
        }
    }
}
