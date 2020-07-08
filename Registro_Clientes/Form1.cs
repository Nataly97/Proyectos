using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cliente objCliente = new Cliente(); //Instanciar la clase
        double cod = 1d;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            double doc1 = 0d;
            if (!double.TryParse(txtDocumento.Text, out doc1))
            {
                errorProvider1.SetError(txtDocumento, "Ingrese un número de documento");
                txtDocumento.Focus();
                return;
            }
            errorProvider1.SetError(txtDocumento, "");


            if (txtNombres.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombres, "Ingrese al menos un nombre");
                txtNombres.Focus();
                return;
            }
            errorProvider1.SetError(txtNombres, "");

            if (txtApellidos.Text.Trim() == "")
            {
                errorProvider1.SetError(txtApellidos, "Ingrese al menos un apellido");
                txtApellidos.Focus();
                return;
            }
            errorProvider1.SetError(txtApellidos, "");

            if (txtCorreo.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCorreo, "Ingrese un correo");
                txtCorreo.Focus();
                return;
            }
            errorProvider1.SetError(txtCorreo, "");

            if (cboTipoCliente.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboTipoCliente, "Seleccione el tipo de cliente");
                cboTipoCliente.Focus();
                return;
            }
            errorProvider1.SetError(cboTipoCliente, "");

            objCliente.Documento = txtDocumento.Text;
            objCliente.Nombre = txtNombres.Text;
            objCliente.Apellido = txtApellidos.Text;
            objCliente.Correo = txtCorreo.Text;
            objCliente.TipoCliente1 = cboTipoCliente.Text;
            /*doc, txtDocumento.Text, txtDocumento, txtNombres, txtApellidos, txtCorreo, cboTipoCliente.SelectedText.ToString()*/
            dgvClientes.Rows.Add(objCliente.Documento, objCliente.Nombre, objCliente.Apellido, objCliente.Correo, objCliente.TipoCliente1);

        }
        int posicion;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de eliminar el cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvClientes.Rows.RemoveAt(posicion);

                btnEliminar.Enabled = false;
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
                btnRegistrar.Enabled = true ;
            }
            }

        public void limpiar()
        {
            txtDocumento.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            cboTipoCliente.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvClientes.CurrentRow.Index;
            btnEliminar.Enabled = true; //Habilita eliminar
            btnRegistrar.Enabled = false;// Dehabilita el boton agregar
        }
    }
}
