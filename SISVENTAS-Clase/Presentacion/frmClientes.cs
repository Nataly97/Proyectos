using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;//Se agrega
using Negocios; //Se agrega 

namespace Presentacion
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        NCliente objNCliente = new NCliente();
        DCliente objDCliente = new DCliente();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            double doc = 0d, tel = 0d;
            if (!double.TryParse(txtDocumento.Text, out doc))
            {
                errorProvider1.SetError(txtDocumento, "Ingrese un número de documento");
                txtDocumento.Focus();
                return;
            }
            errorProvider1.SetError(txtDocumento, "");

            if (txtNombres.Text == string.Empty)
            {
                errorProvider1.SetError(txtNombres, "Escriba el nombre compreto del cliente");
                txtNombres.Focus();
                return;
            }
            errorProvider1.SetError(txtNombres, "");

            if (!double.TryParse(txtTelefono.Text, out tel))
            {
                errorProvider1.SetError(txtTelefono, "Ingrese un número de teléfono");
                txtTelefono.Focus();
                return;
            }
            errorProvider1.SetError(txtTelefono, "");
            
            
            objDCliente.Documento = Convert.ToString (doc);
            objDCliente.NombreCompleto = Convert.ToString(txtNombres.Text);
            objDCliente.Telefono = Convert.ToString(txtTelefono.Text);
            objDCliente.TipoCliente = Convert.ToString (cboTipoCliente.Text);
            bool id = objNCliente.registroCliente(objDCliente);
            if (id == true)
            {
                MessageBox.Show("Registro exitoso");
                dgvListaClientes.DataSource = objNCliente.TablaClientes();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al reggistrar cliente");
            }
        }

        private void Limpiar()
        {
            txtDocumento.Clear();
            txtNombres.Clear();
            txtTelefono.Clear();
            cboTipoCliente.SelectedIndex = -1;
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            dgvListaClientes.DataSource = objNCliente.TablaClientes();
        }

        int id;
        private void dgvListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvListaClientes.Rows[dgvListaClientes.CurrentRow.Index].Cells[0].Value);
            if (MessageBox.Show("Esta seguro de eliminar el cliente " + objDCliente.NombreCompleto + " con Id "+ id,  " Confirmación,", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               bool Id = objNCliente.EliminarCliente(id);
                if (Id == true)
                {
                    MessageBox.Show("El cliente " + id + " fue eliminado exitosamente");
                    dgvListaClientes.DataSource = objNCliente.listaDeClientes();
                    //btnRegistrar.Enabled = false;
                    //btnEditar.Enabled = false;
                    //btnLimpiar.Enabled = false;
                    dgvListaClientes.ClearSelection();
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un cliente");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

    }
}
