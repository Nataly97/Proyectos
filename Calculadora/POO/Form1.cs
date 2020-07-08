using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //LLamar la clase creada antes
        //objCalculadora es una variable 
        Calculadora objCalculadora = new Calculadora(); //Instanciar la clase
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //validar campos con error provaider
            //definir dos variables
            double num1 = 0d, num2 = 0d;
            if (!double.TryParse(txtNumero1.Text, out num1))
            {
                errorProvider1.SetError(txtNumero1, "Ingrese un número valido");
                txtNumero1.Focus();
                return;
            }
            errorProvider1.SetError(txtNumero1, "");

            if (!double.TryParse(txtNumero2.Text, out num2))
            {
                errorProvider1.SetError(txtNumero2, "Ingrese un número valido");
                txtNumero2.Focus();
                return;
            }
            errorProvider1.SetError(txtNumero2, "");
            //Se debe poner afuera de la condición if para que lo tome en todas las condiciones 
            objCalculadora.Numero1 = num1;//enviar el valor al atributo (numero1) de la clase Calculadora)
            objCalculadora.Numero2 = num2;//enviar el valor al atributo (numero1) de la clase Calculadora)//FUNCIÓN
            //Validar si hay un chech marcado de rdo
            //Cuando es proceimiento no hay que guardarlo en una variable //Si es una función se tiene que crear una variable para guardar el resultado 
            if (rdoSumar.Checked==true)
            {
                
                double sum = objCalculadora.suma(); //Guardamos el valor que retornó la función suma en la variable sum
                lblResultado.Text = sum.ToString(); //enviamos el valor al lebe resultado
               // lblResultado.Text = Convert.ToString(sum); (Otra forma de converdir cadena a número 
            }
            //PROCEDIMIENTO
            if (rdoRestar.Checked)
            {
                objCalculadora.resta();//Ejecutar el metodo de la clase
                lblResultado.Text = "" + objCalculadora.Resultado; //Otra forma de convertir para mostrar el resultado 
                                                                    //con el metodo get retorno la resta
                                                                    //del metodo a su atributo resultado 
            }
            if(rdoMultiplicar.Checked)
            {
                objCalculadora.multiplicacion();
                lblResultado.Text = "" + objCalculadora.Resultado;
                    
             }
            if(rdoDividir.Checked)
            {
                if(num2 == 0d)
                {
                    MessageBox.Show("No se puede dividir entre cero");
                    txtNumero2.Clear();
                    txtNumero2.Focus();
                }
                else
                {
                    objCalculadora.division();
                    lblResultado.Text = "" + objCalculadora.Resultado; // El + es indispensable para poder unir
                }
            }
            if (rdoPotencia.Checked)
            {
                objCalculadora.potencia();
                lblResultado.Text = "" + objCalculadora.Resultado;
            }
        }

        private void rdoSumar_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
