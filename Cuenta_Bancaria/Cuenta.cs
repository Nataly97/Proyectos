using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_Bancaria
{
    public class Cuenta
    {
        private double movimiento;
        private double depositar;
        private double retirar;
        private double saldoActual;


        public double Movimiento { get => movimiento; set => movimiento = value; }
        public double Depositar { get => depositar; set => depositar = value; }
        public double Retirar { get => retirar; set => retirar = value; }
        public double SaldoActual { get => saldoActual; set => saldoActual = value; }

        
    }
}
