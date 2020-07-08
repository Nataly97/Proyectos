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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Conexion clsConexion = new Conexion(); // Proceso para insertar la clase
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(clsConexion.conectar());
            if (txtUsuario.Text.Trim()=="") //trim corta los espacios de la izquierda y la derecha
            {
                errorProvider1.SetError(txtUsuario, "Ingrese un suario");
                txtUsuario.Focus();
                return;
            }
            errorProvider1.SetError(txtUsuario, "");

            if (txtContraseña.Text.Trim() == "")
            {
                errorProvider1.SetError(txtContraseña, "Ingrese una clave");
                txtContraseña.Focus();
            }
            errorProvider1.SetError(txtUsuario, "");
            string[] data = new string[6];
            data = clsConexion.validarUsuario(txtUsuario.Text, txtContraseña.Text);
            if (data[1].ToString()== txtUsuario.Text && data[2].ToString() == txtContraseña.Text)
            {
                Principal ppl = new Principal();
                ppl.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o/y contraseña incorrectos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
