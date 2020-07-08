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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        Form1 login; //Llamar el formulario de login

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro que desea salir?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                login = new Form1(); //Instancia del formulario
                login.Show(); //Mostrar el login
                this.Hide();//Ocultar el formulario
            }
        }

        private void gestiónDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos producto = new frmProductos(); 
            producto.MdiParent = this;//Productos es el formulario hijo del Padre Principal //this se refiere a este formulario
            producto.Show();//Hacer el formulario visible 
        }

    }
}
