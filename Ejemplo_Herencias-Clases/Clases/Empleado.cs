using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    //Con los dos puntos se indica la Herencia
    public class Empleado : Persona
    {
        private string tipoContrato;
        private int horas;
        private double valor;
        private double sueldo;

        //Constructor Vacio
        public Empleado() { }

        //Constructor con parametros
        public Empleado (int horas, double valor)
        {
            this.horas = horas;
            this.valor = valor;
            this.sueldo = horas * valor;
        }

        public string TipoContrato { get => tipoContrato; set => tipoContrato = value; }
        public int Horas { get => horas; set => horas = value; }
        public double Valor { get => valor; set => valor = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public void calcularSueldo()
        {
            this.sueldo = this.horas * this.valor;
        }
    }
}
