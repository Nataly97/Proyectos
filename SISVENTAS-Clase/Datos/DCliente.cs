using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; //DataTable (formato de tablas)

namespace Datos
{
    public class DCliente : Conexion
    {
        private int idCliente;
        private string nombreCompleto;
        private string documento;
        private string telefono;
        private string tipoCliente;

        SqlConnection con = new SqlConnection(cadenaConexion());

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string TipoCliente { get => tipoCliente; set => tipoCliente = value; }

        //Registrar cliente 

        public bool registrarCliente(DCliente cliente)
        {
            SqlCommand cmd = new SqlCommand("SP_RegistrarCliente", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@documento", cliente.Documento);
            cmd.Parameters.AddWithValue("@nombreCompleto", cliente.NombreCompleto);
            cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@tipoCliente", cliente.TipoCliente);
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

        //Crear lista de clientes para llenar comboBox de clientes  
        public DataTable listaClientes()
        {
            SqlCommand cmd = new SqlCommand("SP_ListaClientes", con);
            cmd.CommandType = CommandType.StoredProcedure; //Tipo de consulta (Procedimiento almacenado)
            try
            {
                con.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                DataRow fila;
                adaptador.Fill(tabla);
                fila = tabla.NewRow();
                fila["NombreCompleto"] = "Seleccione";
                tabla.Rows.InsertAt(fila, 0);
                con.Close();
                return tabla;
            }
            catch (Exception e) 
            {

                throw new Exception(e.Message);
            }
        }

        public DataTable listarClientes()
        {
            SqlCommand cmd = new SqlCommand("SP_TablaClientes", con);
            cmd.CommandType = CommandType.StoredProcedure; //Tipo de consulta (Procedimiento almacenado)
            try
            {
                con.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                con.Close();
                return tabla;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public bool eliminarCliente(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_eliminarCliente", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
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

        public bool editarCliente(DCliente cliente)
        {
            SqlCommand cmd = new SqlCommand("SP_EditarCliente", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //Enviar parametros
            cmd.Parameters.AddWithValue("@documento", cliente.Documento);
            cmd.Parameters.AddWithValue("@nombreCompleto", cliente.NombreCompleto);
            cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@tipoCliente", cliente.TipoCliente);

            //Excepción de errores
            try
            {
                con.Open(); //Abrir
                cmd.ExecuteNonQuery(); //Ejecutar la consulta
                con.Close();//Cerrar
                return true;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
    }
}
