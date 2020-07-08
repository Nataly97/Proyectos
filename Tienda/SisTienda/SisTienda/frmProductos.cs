using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisTienda
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        //Instanciar la clase conexión
        Conexion clsConexion = new Conexion();
        //El evento Load es lo primero que va a hacer el formulario
        private void frmProductos_Load(object sender, EventArgs e)
        {
            //llenar la tabla con el objeto de la clase conesion que retorna de la DataTable
            dgvProductos.DataSource = clsConexion.listadoProducto();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            float precioC= 0f, percioV = 0f;
            int cantidad = 0;
            bool respuesta;

            precioC = Convert.ToSingle(txtPrecioCompra.Text); //Convertir a float.
            percioV = Convert.ToSingle(txtPrecioVenta.Text); //convertira float
            cantidad = Convert.ToInt32(txtCantidad.Text); //convertir a entero 
           
            //error
            respuesta = clsConexion.registrarProducto(txtProducto.Text, txtDescripcion.Text, precioC, percioV, cantidad);
            
            if (respuesta == true)
            {
                MessageBox.Show("Registro exitoso");
                dgvProductos.DataSource = clsConexion.listadoProducto();//Actualizar tabla
                limpiar(); //Llamar el metodo limir de la parte inferior
            }
            else
            {
                MessageBox.Show("Error al registrar");
            }
        }
        
        void limpiar()
        {
            txtProducto.Clear(); txtDescripcion.Clear(); txtPrecioCompra.Clear(); txtPrecioVenta.Clear(); txtCantidad.Clear();
        }

        int id;
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAtras.Visible = true;
            btnAtras.Enabled = true;
            btnCancelar.Enabled = true;
            id = Convert.ToInt32(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value);
           // MessageBox.Show("Id Producto: " + id);//Prueba para vadiradr si esta captudarndo el Id
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAtras.Visible = false;
            dgvProductos.ClearSelection(); //Limpiar la selección de la tabla, a la celda seleccionada se quita la selección
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtProducto.Text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[1].Value.ToString();
            txtDescripcion.Text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[2].Value.ToString();
            txtPrecioCompra.Text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[3].Value.ToString();
            txtPrecioVenta.Text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[4].Value.ToString();
            txtCantidad.Text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[5].Value.ToString();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAtras.Enabled = false;
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            dgvProductos.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAtras.Enabled = true;
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            dgvProductos.Enabled = true;
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            float precioC = 0f, percioV = 0f;
            int cantidad = 0;
            bool respuesta;

            precioC = Convert.ToSingle(txtPrecioCompra.Text); //Convertir a float.
            percioV = Convert.ToSingle(txtPrecioVenta.Text); //convertira float
            cantidad = Convert.ToInt32(txtCantidad.Text); //convertir a entero 

            respuesta = clsConexion.editarProducto(txtProducto.Text, txtDescripcion.Text, precioC, percioV, cantidad, id);

            if (respuesta == true)
            {
                MessageBox.Show("Actualización exitosa");
                dgvProductos.DataSource = clsConexion.listadoProducto();
                btnAgregar.Enabled = true;
                dgvProductos.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = false;
                btnGuardar.Visible = false;
                btnCancelar.Visible = false;
                dgvProductos.ClearSelection();
                limpiar();
            }
            else
            {
                MessageBox.Show("Error al actualizar, comuniquese con soporte técnico");
            }
                
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string producto = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[1].Value.ToString();
            if (MessageBox.Show("Esta seguro de eliminar el producto "+producto+" con Código "+id," Confirmación,",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                bool del = clsConexion.eliminarProducto(id);
                if(del == true)
                {
                    MessageBox.Show("El producto " + producto + " fue eliminado exitosamente");
                    dgvProductos.DataSource = clsConexion.listadoProducto();
                    btnAgregar.Enabled = true;
                    dgvProductos.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnGuardar.Visible = false;
                    btnCancelar.Visible = false;
                    dgvProductos.ClearSelection();
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("Error al eliminar el producto");
            }
        }
    }
}
