using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parenthesis_Beautifier
{
    public class ArbolLiterales
    {
        public Literal raiz;

        public List<ArbolLiterales> subArboles;
        int profundidad;

        public void AgregarHoja(Literal nuevaHoja)
        {
            if(raiz == null)
            {
                raiz = nuevaHoja;
            }

            subArboles.Add(nuevaHoja);
        }

        public ArbolLiterales()
        {
            subArboles = new List<ArbolLiterales>();
        }
    }
}
