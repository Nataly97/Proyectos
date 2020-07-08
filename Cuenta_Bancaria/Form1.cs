using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuenta_Bancaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cuenta objCuenta = new Cuenta();

        double Movi=1d;
        private void btnDeposito_Click(object sender, EventArgs e)
        {
            double dep = 0d;
            if (!double.TryParse(txtMovimiento.Text, out dep))
            {
                errorProvider1.SetError(txtMovimiento, "Ingrese un valor" + "");
                txtMovimiento.Focus();
                return;
            }
            errorProvider1.SetError(txtMovimiento, "");

            objCuenta.Movimiento += Movi;
            objCuenta.Depositar = dep;
            objCuenta.SaldoActual += dep;

            if (MessageBox.Show("¿Esta seguro que desea hacer el Deposito o Retiro?",
               "Confirmación",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)

            {
                dgvMovimientos.Rows.Add(objCuenta.Movimiento, objCuenta.Depositar, objCuenta.Retirar = 0, objCuenta.SaldoActual);
            }

        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            double ret = 0d;
            if (!double.TryParse(txtMovimiento.Text, out ret))
            {
                errorProvider1.SetError(txtMovimiento, "Ingrese un valor" + "");
                txtMovimiento.Focus();
                return;
            }
            errorProvider1.SetError(txtMovimiento, "");

            objCuenta.Movimiento += Movi;
            objCuenta.Retirar = ret;
            objCuenta.SaldoActual -= ret;

            if (MessageBox.Show("¿Esta seguro que desea hacer el Deposito o Retiro?",
               "Confirmación",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)

            {
                dgvMovimientos.Rows.Add(objCuenta.Movimiento, objCuenta.Depositar = 0, objCuenta.Retirar, objCuenta.SaldoActual);
            }
            if (objCuenta.SaldoActual < 0)
            {
                MessageBox.Show("El retiro genera saldo negativo en la cuenta");
            }
        }
    }
}