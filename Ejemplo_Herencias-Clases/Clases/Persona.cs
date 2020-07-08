using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        //atributos 
        private long documento;
        private string nombres;
        private string apellidos;
        private string tipo;

        public long Documento { get => documento; set => documento = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        //metodo set y get(click derecho encapcular usando propiedades)
    }
}
