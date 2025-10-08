using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parenthesis_Beautifier
{
    public class Literal
    {
        public int profunidad;
        public string texto;
        public int id;
        public Literal padreObj;

        public Literal(int profunidad, string texto, int id)
        {
            this.profunidad = profunidad;
            this.texto = texto;
            this.id = id;
        }

        public Literal(int profunidad, string texto, int id, Literal padreObj)
        {
            this.profunidad = profunidad;
            this.texto = texto;
            this.id = id;
            this.padreObj = padreObj;
        }
    }

    
}
