using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piedra__Papel_o_Tijera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Clase obJugador1 = new Clase();
        Clase obJugador2 = new Clase();

        private void btnPiedra1_Click(object sender, EventArgs e)
        {
            obJugador1.Piedra = true;
                MessageBox.Show("Siguiente jugador");
                btnPiedra1.Visible = false;
                btnPapel1.Visible = false;
                btnTijera1.Visible = false;
                btnPiedra2.Enabled = true;
                btnPapel2.Enabled = true;
                btnTijera2.Enabled = true;
        }

        private void btnPapel1_Click(object sender, EventArgs e)
        {
            obJugador1.Papel = true;
                MessageBox.Show("Siguiente jugador");
                btnPiedra1.Visible = false;
                btnPapel1.Visible = false;
                btnTijera1.Visible = false;
                btnPiedra2.Enabled = true;
                btnPapel2.Enabled = true;
                btnTijera2.Enabled = true;
        }

        private void btnTijera1_Click(object sender, EventArgs e)
        {
            obJugador1.Tijeta = true;
                MessageBox.Show("Siguiente jugador");
                btnPiedra1.Visible = false;
                btnPapel1.Visible = false;
                btnTijera1.Visible = false;
                btnPiedra2.Enabled = true;
                btnPapel2.Enabled = true;
                btnTijera2.Enabled = true;
        }

        private void btnPiedra2_Click(object sender, EventArgs e)
        {
            obJugador2.Piedra = true;
            bool res = false;
            if (obJugador1.Piedra == true && obJugador2.Piedra == true)
            {
                obJugador1.Resultado = "Empate";
            }
           if (obJugador1.Papel == true && obJugador2.Piedra == true)
            {
                obJugador1.Resultado = "El ganador es: Jugador 1";
            }

            if (obJugador1.Tijeta == true && obJugador2.Piedra == true)
            {
                obJugador1.Resultado = "El ganador es: Jugador 2";
            }
            btnPiedra2.Visible = false;
            btnPapel2.Visible = false;
            btnTijera2.Visible = false;
            MessageBox.Show(obJugador1.Resultado);
            btnNuevo.Visible = true;
            btnNuevo.Enabled = true;
        }

        private void btnPapel2_Click(object sender, EventArgs e)
        {
            obJugador2.Papel = true;
            bool res = false;
            if (obJugador1.Papel == true && obJugador2.Papel == true)
            {
                obJugador1.Resultado = "Empate";
            }

            if (obJugador1.Piedra == true && obJugador2.Papel == true)
            {
                obJugador1.Resultado = "El ganador es: Jugador 2";
            }

            if (obJugador1.Tijeta == true && obJugador2.Papel == true)
            {
                obJugador1.Resultado = "El ganador es: Jugador 1";
            }

            btnPiedra2.Visible = false;
            btnPapel2.Visible = false;
            btnTijera2.Visible = false;
            MessageBox.Show(obJugador1.Resultado);
            btnNuevo.Visible = true;
            btnNuevo.Enabled = true;
        }

        private void btnTijera2_Click(object sender, EventArgs e)
        {
            obJugador2.Tijeta = true;
            bool res = false;
            if (obJugador1.Tijeta == true && obJugador2.Tijeta == true)
            {
                obJugador1.Resultado = "Empate";
            }

            if (obJugador1.Piedra == true && obJugador2.Tijeta == true)
            {
                obJugador1.Resultado = "El ganador es: Jugador 1";
            }

            if (obJugador1.Papel == true && obJugador2.Tijeta == true)
            {
                obJugador1.Resultado = "El ganador es: Jugador 2";
            }
            btnPiedra2.Visible = false;
            btnPapel2.Visible = false;
            btnTijera2.Visible = false;
            MessageBox.Show(obJugador1.Resultado);
            btnNuevo.Visible = true;
            btnNuevo.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            obJugador1.Papel = false;
            obJugador1.Piedra = false;
            obJugador1.Tijeta = false;
            obJugador1.Resultado = "";
            obJugador2.Papel = false;
            obJugador2.Piedra = false;
            obJugador2.Tijeta = false;
            obJugador2.Resultado = "";
            btnPiedra1.Visible = true;
            btnPapel1.Visible = true;
            btnTijera1.Visible = true;
            btnPiedra2.Visible = true;
            btnPapel2.Visible = true;
            btnTijera2.Visible = true;
            btnPiedra2.Enabled = false;
            btnPapel2.Enabled = false;
            btnTijera2.Enabled = false;
            btnNuevo.Enabled = false;
            
        }
    }
}
