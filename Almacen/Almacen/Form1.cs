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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 5;//Acumula 5 en 5
            Principal principal = new Principal();
            if (progressBar1.Value>99)
            {
                timer1.Stop();//Detener el reloj
                principal.Show(); //Sea visible el formulario principal
                this.Hide();//Se oculte el formulario (login)
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Trim() == "")
            {
                errorProvider1.SetError(txtUsuario, "Ingrese un usuario");
                txtUsuario.Focus();
                return;
            }
            errorProvider1.SetError(txtUsuario, "");

            if (txtClave.Text.Trim() == "")
            {
                errorProvider1.SetError(txtClave, "Ingrese contraseña");
                txtClave.Focus();
                return;
            }
            errorProvider1.SetError(txtClave, "");

            //Validar si el usuario es correcto y la contraseña
            if(txtUsuario.Text == "nataly" && txtClave.Text == "123")
            {
                progressBar1.Visible = true;
                timer1.Start(); //iniciar el evento tick
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta");
            }
        }
    }
}
