using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        double subtotales = 0d;
        int cod = 1;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtProducto.Text.Trim() == "")
            {
                errorProvider1.SetError(txtProducto, "Ingrese producto");
                txtProducto.Focus();
                return;
            }
            errorProvider1.SetError(txtProducto, "");

            int cant = 0;
            double prec = 0d;
            //! negación 
            if (!double.TryParse(txtPrecio.Text, out prec))
            {
                errorProvider1.SetError(txtPrecio, "Ingrese un precio valido");
                txtPrecio.Focus();
                return;
            }
            errorProvider1.SetError(txtPrecio, "");

            if (!int.TryParse(txtCantidad.Text, out cant))
            {
                errorProvider1.SetError(txtCantidad, "Ingrese una cantidad valida");
                txtCantidad.Focus();
                return;
            }
            errorProvider1.SetError(txtCantidad, "");
            //Validar el ComboBox
            if (cboCategoria.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboCategoria, "Seleccione una categoría");
                cboCategoria.Focus();
                return;
            }
            errorProvider1.SetError(cboCategoria, "");
            double subtotalP = 0d;
            subtotalP = prec * cant;
            //Subtotal = subtotal + subtotalP; acumuladora
            subtotales += subtotalP;
            //enviar el registro a la tabla productos 
            dgvProducto.Rows.Add(cod, txtProducto.Text,prec, cant,subtotalP,cboCategoria.SelectedText.ToString());

            //COntador
            //Cod 0 cod +1;
            cod++;
            txtTotal.Text = Convert.ToString(subtotales);
        }
        public void limpiar()
        {
            txtProducto.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            cboCategoria.SelectedIndex = -1;
        }
        int posicion;
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvProducto.CurrentRow.Index;
            btnEliminar.Enabled = true; //Habilita eliminar
            btnAgregar.Enabled = false;// Dehabilita el boton agregar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro de eliminar el producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                //Restar al total el producto eliminado

                double restar = Convert.ToDouble(dgvProducto.Rows[posicion].Cells[2].Value) * Convert.ToDouble(dgvProducto.Rows[posicion].Cells[3].Value);
                dgvProducto.Rows.RemoveAt(posicion);
                subtotales -= restar;
                dgvProducto.Rows.RemoveAt(posicion);
                txtTotal.Text = Convert.ToString(subtotal);

                btnEliminar.Enabled = false;
                btnAgregar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
                btnAgregar.Enabled = true;
            }
        }
    }
}
