using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{                       //Herencia
    public class Cliente : Persona
    {
        private string categoria;
        private string codigo;

        public string Categoria { get => categoria; set => categoria = value; }
        public string Codigo { get => codigo; set => codigo = value; }

        //Constructor vacio 
        public Cliente() { }

        //Constructor con parametros 
        public Cliente(string categoria, long documento)
        {
            this.categoria = categoria;
            this.Documento = documento;
            this.codigo = "C" + this.categoria + "-"+ Convert.ToString(this.Documento);
        }

        public void generarCodigo()
        {
            this.codigo = "C" + this.categoria + "-" + Convert.ToString(this.Documento);

        }
    }
}
