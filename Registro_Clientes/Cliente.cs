using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller
{
    public class Cliente
    {
        private string documento;
        private string nombre;
        private string apellido;
        private string correo;
        private string TipoCliente;

        public string Documento { get => documento; set => documento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public string TipoCliente1 { get => TipoCliente; set => TipoCliente = value; }


    }
}
