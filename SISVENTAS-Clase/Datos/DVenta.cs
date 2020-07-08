using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DVenta : Conexion
    {
        //Atributos de la tabla venta 
        private int idVenta;
        private DateTime fecha;
        private int idCliente;
        private float total;
        private int estado;

        //atributos de la tabla detalles de venta 
        private int idDetalle;
        private int idProducto;
        private float precio;
        private int cantidad;
        private float subtotal;
 
        // metodos set y get 
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public float Total { get => total; set => total = value; }
        public int Estado { get => estado; set => estado = value; }
        public int IdDetalle { get => idDetalle; set => idDetalle = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Subtotal { get => subtotal; set => subtotal = value; }

        //Metodos registrar 
        SqlConnection con = new SqlConnection(cadenaConexion());
        public string registroVenta(DVenta venta)
        {
            SqlCommand cmd = new SqlCommand("SP_RegistrarVenta", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fecha", venta.Fecha);
            cmd.Parameters.AddWithValue("@idCliente", venta.IdCliente);
            cmd.Parameters.AddWithValue("@total", venta.Total);
            cmd.Parameters.AddWithValue("@estado", venta.Estado);
            try
            {
                con.Open();
                string id = cmd.ExecuteScalar().ToString();//Devolver el dato
                con.Close();
                return id;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        
    
	
     
	
        public bool registrarDetalles(DVenta venta)
        {
            SqlCommand cmd = new SqlCommand("SP_RegistarDetallesVenta", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idProducto ", venta.IdProducto);
            cmd.Parameters.AddWithValue("@idVenta", venta.IdVenta);
            cmd.Parameters.AddWithValue("@precio", venta.Precio);
            cmd.Parameters.AddWithValue("@cantidad", venta.Cantidad);
            cmd.Parameters.AddWithValue("@subtotal", venta.Subtotal);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        //Listar las ventas registradas 
        public DataTable ListarVentas()
        {
            
            SqlCommand cmd = new SqlCommand("SP_ListarVentas", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

    }
}
