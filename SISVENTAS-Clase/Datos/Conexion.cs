using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//Conexión con SQL (Base de datos)

namespace Datos
{
    public class Conexion
    {
        //metodo que retorna la cadena de conexión 
        public static string cadenaConexion()
        {
            return "Data Source=LAPTOP-0BRFAK9R\\SQLEXPRESS; Initial Catalog=SISVENTAS; Integrated Security=True";
        }
    }
}
