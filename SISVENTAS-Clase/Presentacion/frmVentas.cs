using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios; //Hace referencia a la capa de Negocio (Libreria Negocios)
using Datos;


namespace Presentacion
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        NProducto objNProcucto = new NProducto();
        NCliente objNCliente = new NCliente();
        private void frmVentas_Load(object sender, EventArgs e)
        {
            dgvVentas.DataSource = objDventa.ListarVentas();

            cboProducto.DataSource = objNProcucto.ListaDeProductos();
            cboProducto.DisplayMember = "Producto";// Ver el usuario en el combobox (lista de productos)
            cboProducto.ValueMember = "IdProducto";//ID del producto seleccionado

            cboCliente.DataSource = objNCliente.listaDeClientes();
            cboCliente.DisplayMember = "NombreCompleto"; // Ver el usuario en el comboBox (Lista de clientes)
            cboCliente.ValueMember = "IdCLiente"; //ID del cliente seleccionado 
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducto.SelectedIndex != 0)
            {
                int id = Convert.ToInt32(cboProducto.SelectedValue.ToString());
                txtPrecio.Text = objNProcucto.getPrecioProducto(id); ;
            }
            else
            {
                txtCantidad.Clear();
                txtPrecio.Clear();
            }
        }

        float sub = 0f, valorIva = 0f, total= 0f;

        int idD;

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            //Validar que no este vacia la tabla (detalles)
            if(dgvDetalles.RowCount <= 0)
            {
                MessageBox.Show("No hay productos para eliminar");
            }
            else
            {
                //Tarea: Como actualizar el sutotal 
                float restar = Convert.ToSingle(dgvDetalles.Rows[idD].Cells[4].Value);
                sub -= restar;
                dgvDetalles.Rows.RemoveAt(idD);
                txtSubtotal.Text = Convert.ToString(sub);
                valorIva = sub * 0.19f;
                txtIva.Text = Convert.ToString(valorIva);
                total = sub + valorIva;
                txtTotal.Text = Convert.ToString(total);
                cboProducto.SelectedIndex = 0;
                txtPrecio.Clear();
                txtCantidad.Clear();
                dgvDetalles.ClearSelection();
            }
        }

        NVenta objNVenta = new NVenta(); //Capa de negocio la clase NVenta (metodo)
        DVenta objDventa = new DVenta(); //capa de datos la clase DVenta (atibutos)
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            //Validar selección del cliente 
            if(cboCliente.SelectedIndex== 0)
            {
                errorProvider1.SetError(cboCliente, "Seleccione un cliente");
                cboProducto.Focus();
                return;
            }
            errorProvider1.SetError(cboCliente, "");

            //Validar tabla de detalles 
            if (dgvDetalles.RowCount == 0 )
            {
                errorProvider1.SetError(dgvDetalles,"No hay productos para registrar");
                cboProducto.Focus();
                return;
            }
            errorProvider1.SetError(dgvDetalles, "");
            objDventa.Fecha = dtpFechaVenta.Value;
            objDventa.IdCliente = Convert.ToInt32(cboCliente.SelectedValue.ToString());
            objDventa.Total = total;
            objDventa.Estado = 1;
            string idv = objDventa.registroVenta(objDventa);
            if(idv != null)
            {
                int contarFilas = dgvDetalles.RowCount;
                int contador = 0;
                foreach (DataGridViewRow fila in dgvDetalles.Rows)
                {
                    objDventa.IdProducto = Convert.ToInt32(fila.Cells[0].Value);
                    objDventa.IdVenta = Convert.ToInt32(idv);
                    objDventa.Precio = Convert.ToSingle(fila.Cells[2].Value);
                    objDventa.Cantidad = Convert.ToInt32(fila.Cells[3].Value);
                    objDventa.Subtotal = Convert.ToSingle(fila.Cells[4].Value);
                    bool res = objDventa.registrarDetalles(objDventa);
                    if(res)
                    {
                        contador++;
                    }
                }
                if(contador == contarFilas)
                {
                    MessageBox.Show("Registro exitoso");
                    dgvVentas.DataSource = objDventa.ListarVentas();
                }
            }
            else
            {
                MessageBox.Show("Error al registrar venta");
            }

        }

        private void dgvDetalles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idD = (int)dgvDetalles.CurrentRow.Index;
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            sub = 0f;
            int cantidad = 0, cont = 0, idP;
            float precio = 0f, Subtotal = 0f;
            string producto = "";
            //Validar combobox producto
            if(cboProducto.SelectedIndex == 0)
            {
                errorProvider1.SetError(cboProducto, "Seleccione un producto");
                cboProducto.Focus();
                return;
            }
            errorProvider1.SetError(cboProducto, "");
            producto = cboProducto.Text.ToString();
            precio = Convert.ToSingle(txtPrecio.Text); //Converir a float (de texto a número)
            //Validar cantidad
            if(!Int32.TryParse(txtCantidad.Text, out cantidad))
            {
                errorProvider1.SetError(txtCantidad, "Ingrese una cantidad valida");
                txtCantidad.Focus();
                return;
            }
            errorProvider1.SetError(txtCantidad, "");
            if(cantidad <= 0)
            { 
                errorProvider1.SetError(txtCantidad, "Ingrese una cantidad mayor a cero");
                txtCantidad.Focus();
                return;
            }
            errorProvider1.SetError(txtCantidad, "");

            idP = Convert.ToInt32(cboProducto.SelectedValue.ToString());
            Subtotal = cantidad * precio;
            for (int i = 0; i < dgvDetalles.Rows.Count; i++)
            {
                if (producto == dgvDetalles.Rows[i].Cells[1].Value.ToString())
                {
                    dgvDetalles.Rows[i].Cells[3].Value = (Convert.ToInt32(dgvDetalles.Rows[i].Cells[3].Value) + cantidad);
                    dgvDetalles.Rows[i].Cells[4].Value = (Convert.ToSingle(dgvDetalles.Rows[i].Cells[4].Value) + (cantidad * precio));
                    
                    cont++;
                }
            }

            if (cont == 0)
            {
                dgvDetalles.Rows.Add(idP, producto, precio, cantidad, Subtotal);
            }
            //Sumando los valores (Subtotal) de los detalles 
            for (int j = 0; j < dgvDetalles.Rows.Count; j++)
            {
                sub += Convert.ToSingle (dgvDetalles.Rows[j].Cells[4].Value.ToString());
            }

            txtSubtotal.Text = Convert.ToString(sub);
            valorIva = sub * 0.19f;
            txtIva.Text = Convert.ToString(valorIva);
            total = sub + valorIva;
            txtTotal.Text = Convert.ToString(total);
            cboProducto.SelectedIndex = 0;
            txtPrecio.Clear();
            txtCantidad.Clear();
        }
    }
}
