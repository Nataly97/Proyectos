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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Productos productos;
        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productos = new Productos(); //llamar el formulario en la variable 
            productos.MdiParent = this;//quien va ser mi formulario padre.
            productos.Show();
        }
    }
}
