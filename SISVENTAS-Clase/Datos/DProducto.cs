using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; //DataTable(Formato de tablas) Se pone para poder llamar las tablas 

namespace Datos
{
    public class DProducto : Conexion
    {
        SqlConnection con = new SqlConnection(cadenaConexion());//Llama la conexión de la base de datos creada en la clase Conexion
        //crear metodo de la lista de productos 
        public DataTable ListaProductos()
        {
            SqlCommand cmd = new SqlCommand("SP_Productos", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);//El adaptador es para adaptar la consulya de sql a visual 
                DataTable datos = new DataTable();
                DataRow fila;
                adaptador.Fill(datos);
                fila = datos.NewRow();
                fila["Producto"] = "Seleccione";
                datos.Rows.InsertAt(fila, 0);
                con.Close();
                return datos;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        //Metodo para retornar el precio del producutos 
        public string preciProducto(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_GetPrecioProducto", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                con.Open();
                string precio = cmd.ExecuteScalar().ToString();
                //cmd.EndExecuteNonQuery(); consulta insert, update y delete cooleando (true - false)
                con.Close();
                return precio;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message); 
            }
        }
    }
}
