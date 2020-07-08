using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocios
{
    public class NVenta
    {
        DVenta objVenta = new DVenta();
        public string registroVenta(DVenta venta)
        {
            return objVenta.registroVenta(venta);
        }
        public bool registrarDetalles(DVenta venta)
        {
            return objVenta.registrarDetalles(venta);
        }
        public DataTable lisVentas()
        {
            return objVenta.ListarVentas();
        }
    }
}
