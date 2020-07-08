using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Calculadora
    {
        //Atributos: Caracteristicas de la clase 
        private double numero1;
        private double numero2;
        private double resultado;
        //Metodos SET y GET
        //Esto sale de click derecho, acciones rapidas , encapcular 
        public double Numero1 { get => numero1; set => numero1 = value; }
        public double Numero2 { get => numero2; set => numero2 = value; }
        public double Resultado { get => resultado; set => resultado = value; }
        //Metodos

            //Función  (devuelve un dato double
            public double suma()
        {       //la variable sum debe ser distinta al metodo suma

            double sum = 0d;
            sum = this.numero1 + this.numero2;

            //Retornar(arrojar el resultado)
            return sum;
        }
        //Procedimiento (guardael resultado dentro del atributo (resultado))
        public void resta()
        {
            this.resultado = this.numero1 - this.numero2;
        }
        public void multiplicacion()
        {
            this. resultado= this.numero1 * this.numero2;
        }
        public void division()
        {
            this.resultado = this.numero1 / this.numero2;
        }
        public void potencia()
        {                               //Base      //Exponente 
            this.resultado = Math.Pow(this.numero1, this.numero2); //Potencia
        }
    }
}
