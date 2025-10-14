using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parenthesis_Beautifier
{
    public class Literal
    {
        public int profundidad;
        public string texto;
        public int id;
        public Literal padreObj;

        public Literal(int profunidad, string texto, int id)
        {
            this.profundidad = profunidad;
            this.texto = texto;
            this.id = id;
        }

        public Literal(int profunidad, string texto, int id, Literal padreObj)
        {
            this.profundidad = profunidad;
            this.texto = texto;
            this.id = id;
            this.padreObj = padreObj;
        }

        public String ToString()
        {
            string resultado = "";

            for (int j = 0; j < profundidad; j++)
                resultado += "    ";
            resultado += texto;

            return resultado;
        }
    }

    
}
