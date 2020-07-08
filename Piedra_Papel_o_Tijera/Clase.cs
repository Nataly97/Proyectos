using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piedra__Papel_o_Tijera
{
    class Clase
    {
        private bool piedra;
        private bool papel;
        private bool tijeta;
        private string resultado;
   

        public bool Piedra { get => piedra; set => piedra = value; }
        public bool Papel { get => papel; set => papel = value; }
        public bool Tijeta { get => tijeta; set => tijeta = value; }
        public string Resultado { get => resultado; set => resultado = value; }
    }
}
