using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisTienda
{
    public class Conexion
    {
        string conexion = "Data Source=LAPTOP-0BRFAK9R\\SQLEXPRESS; Initial Catalog=SisTienda; Integrated Security=True";

        //Metodo para probar la conexión
        public string conectar()
        {
            string respuesta = "";
            //Comando para realizar conexión 
            SqlConnection con = new SqlConnection(conexion);
            try
            {
                con.Open(); //Abrir conexión
                return respuesta = "Conexión exitosa";
            }
            catch (Exception e)
            {
                con.Close();
                return respuesta = "Ha ocurrido un error: \n " + e.Message;
            }
        }

        //Metodo para validar el usurio 
        string[] dataUser = new string[6];
        public string[] validarUsuario(string usuario, string clave)
        {
            //Conectara a la base de datos 
            SqlConnection con = new SqlConnection(conexion);
            //Crear la consulta //cmd es una variable inventada, puede ser cualquiera 
            SqlCommand cmd = new SqlCommand("SELECT IdUsuario, Usuario, Clave, NombreCompleto,TipoUsuario,Estado FROM Usuarios WHERE Usuario = @usuario AND Clave = @clave;", con);

            //Tipo de consulta que se va a realizar en la base de datos
            cmd.CommandType = System.Data.CommandType.Text;

            //Relacionar los parametros
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@clave", clave);

            //Abrir ónexión para que pueda traer el resultado 
            con.Open();

            //Adaptador retornar teclas o datos 
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);

            //Crear instancia de la tabla //Para mostrar datos en tabla 
            DataTable tabla = new DataTable();

            //Llenar la tabla 
            adaptador.Fill(tabla); //Fill significa llenar 
            if (tabla.Rows.Count > 0)//Rows son las filas 
            {
                for (int i = 0; i < dataUser.Length; i++)
                {
                    //Guardar la información del usuario. 
                    dataUser[i] = tabla.Rows[0][i].ToString();
                }
            }
            con.Close(); //Cerrar conexión 
            return dataUser;
        }

        //Crear el método para registrar el producto 

        //bool = true o false //verdadero o falso
        //void no retorna nada, sólo hace la acción
        public bool registrarProducto(string prod, string desc, float precioC, float precioV, int cantidad)//Con estos parametros se reciben los datos del formulario       
        {
            SqlConnection con = new SqlConnection(conexion);
            //identity significa que se va a autoincrementar (IdProducto) SqlServer 
            //NO se debe poner el campo en la consulta (SqlCommand)
            SqlCommand cmd = new SqlCommand("INSERT INTO Productos (Producto, Descripcion, PrecioCompra, PrecioVenta, Cantidad) VALUES (@producto, @descrip, @precioC, @precioV, @cantidad);", con);

            //Tipo de consulta texto o procedimiento 
            cmd.CommandType = CommandType.Text;
            //Parametros 
            cmd.Parameters.AddWithValue("@producto", prod);//Que vamos a enviar a cada parametro
            cmd.Parameters.AddWithValue("@descrip", desc);
            cmd.Parameters.AddWithValue("@precioC", precioC);
            cmd.Parameters.AddWithValue("@precioV", precioV);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            //Excepción de errores //Esto sale de escribir Try y dar doble tabulador
            try //try es intenteme hacer algo 
            {
                con.Open(); //Abrir la conexión, si no se abre no se puede hacer la consulta 
                cmd.ExecuteNonQuery(); //Ejecute la consulta en la base de datos (Para insertar, actualizar y eliminar)
                con.Close(); //Cierro la conexión 
                return true; //retornar el verdadero, aquí se aplica el verdadero o falso 
            }
            catch (Exception e) //Sino, es decier que hay un error //(La e es una variable)
            {

                throw new Exception(e.Message); //Muestreme que pasó
            }
        }

        //Crear el metodo ver/ lista de productos 
        public DataTable listadoProducto()
        {
            SqlConnection con = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand("SELECT IdProducto AS [Código], Producto, Descripcion AS [Descripción], PrecioCompra AS [Precio Compra], PrecioVenta AS [Precio Venta], Cantidad FROM Productos", con);
            cmd.CommandType = CommandType.Text;
            //Excepcion de errores.
            try
            {
                con.Open(); //Abrir la conexión 
                //Captura de la tabla que retorna la consulta 
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                //Crear el adaptador de la tabla que contiene el adaptador DataTable
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                con.Close();//Cierre la conexión
                return tabla;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);//Mensaje de error
            }
        }

        //Metodo editar productos 
        public bool editarProducto(string prod, string desc, float precioC, float precioV, int catidad, int id)
        {
            SqlConnection con = new SqlConnection(conexion); //Llamar la conexión 
            SqlCommand cmd = new SqlCommand ("UPDATE Productos SET Producto =@producto, Descripcion = @des, PrecioCompra = @precioC, PrecioVenta = @precioV, Cantidad =@cant WHERE IdProducto = @id", con); //La consulta

            cmd.CommandType = CommandType.Text; //tipo de consulta
            //Enviar parametros
            cmd.Parameters.AddWithValue("@producto", prod);
            cmd.Parameters.AddWithValue("@des", desc);
            cmd.Parameters.AddWithValue("@precioC", precioC);
            cmd.Parameters.AddWithValue("@precioV", precioV);
            cmd.Parameters.AddWithValue("@cant", catidad);
            cmd.Parameters.AddWithValue("@id", id);

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

        public bool eliminarProducto(int id)
        {
            SqlConnection con = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand("DELETE FROM Productos WHERE IdProducto = @id", con);
            cmd.CommandType = CommandType.Text;
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

    }
}

