using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases; // Segundo paso, llamar el using de la clase creada (el primer paso es llamar la referencia en la clase)

namespace Ejemplo_Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Objetos de la clase empleado y cliente 

        Empleado objEmpleado1 = new Empleado();
        Cliente objCliente1 = new Cliente();
        private void btnObjeto1E_Click(object sender, EventArgs e)
        {
            objEmpleado1.Horas = Convert.ToInt32(txtHorasE.Text);
            objEmpleado1.Valor = Convert.ToDouble(txtValorHoraE.Text);
            objEmpleado1.calcularSueldo();
            objEmpleado1.Nombres = txtNombresE.Text;
            objEmpleado1.Apellidos = txtApellidosE.Text;
            objEmpleado1.Documento = Convert.ToInt64(txtDocumentoE.Text);
            objEmpleado1.Tipo = cboTipoE.SelectedItem.ToString();
            objEmpleado1.TipoContrato = cboContratoE.SelectedItem.ToString();

            MessageBox.Show("El empleado: " + objEmpleado1.Nombres + " " + objEmpleado1.Apellidos + "\n" + "Documento de Identidad: " + objEmpleado1.Documento + "\n" + "Tipo de empleado: " + objEmpleado1.Tipo + "\n" + "Contrato: " + objEmpleado1.TipoContrato + "\n" + "Total a Pagar: " + objEmpleado1.Sueldo, "Información del Pago");
        }

        private void btnObjeto1C_Click(object sender, EventArgs e)
        {
            objCliente1.Documento = Convert.ToInt64(txtDocumentoC.Text);
            objCliente1.Nombres = txtNombresC.Text;
            objCliente1.Apellidos = txtApellidosC.Text;
            objCliente1.Tipo = cboTipoC.SelectedItem.ToString();
            objCliente1.Categoria = cboCategoriaC.SelectedItem.ToString();
            objCliente1.generarCodigo();
            MessageBox.Show("Nombre Complento: " + objCliente1.Nombres + " " + objCliente1.Apellidos + "\n" + "Documento: " + objCliente1.Documento + "\n" + "Tipo y Categoría: " + objCliente1.Tipo + " / " + objCliente1.Categoria + "\n"+"Código del Cliente: "+objCliente1.Codigo, "Información del Cliente");
        }

        private void btnObjeto2E_Click(object sender, EventArgs e)
        {
            Empleado objEmpleado2 = new Empleado(Convert.ToInt32(txtHorasE.Text), Convert.ToDouble(txtValorHoraE.Text));
            MessageBox.Show("El total a pagar es: " + objEmpleado2.Sueldo);
        }

        private void btnObjeto2C_Click(object sender, EventArgs e)
        {
            Cliente objCliente2 = new Cliente(cboCategoriaC.SelectedItem.ToString(), Convert.ToInt64(txtDocumentoC.Text));
            MessageBox.Show("El código del cliente es : " + Convert.ToString (objCliente2.Codigo));
        }
    }
}
