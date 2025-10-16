using System.ComponentModel.Design;
using System.Xml.Linq;

namespace Parenthesis_Beautifier
{
    public partial class VentanaPrincipal : Form
    {
        List<Literal> literales;


        public VentanaPrincipal()
        {
            InitializeComponent();
            literales = new List<Literal>();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            tbOriginal.Select();
            tbOriginal.Text = "funcion(funcion(x))";
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            string contenido = "hey";
            System.Windows.Forms.Clipboard.SetText(contenido);
        }

        private void tbOriginal_TextChanged(object sender, EventArgs e)
        {
            string textoResultado = ponerBonito(tbOriginal.Text);
            tbResultado.Text = textoResultado;

            ponerBonito2(tbOriginal.Text);
        }

        string ponerBonito(String textoO)
        {
            string resultado = "";
            int profundidad = 0;


            for (int i = 0; i < textoO.Length; i++)
            {
                resultado += textoO[i];

                if (textoO[i] == '(')
                {
                    
                    if (textoO.Length - i > 1 && textoO[i + 1] == ')')
                        continue;

                    //if(parentesisVacio)


                    profundidad++;
                    resultado += "\r\n";

                    for (int j = 0; j < profundidad; j++)
                        resultado += "    ";


                }

                if (textoO[i] == ')')
                {
                    if (i-1 >= 0 && textoO[i-1] == '(')
                        continue;

                    profundidad--;
                    resultado = resultado.Remove(resultado.Length - 1);
                    resultado += "\r\n";
                    for (int j = 0; j < profundidad; j++)
                        resultado += "    ";
                    resultado += textoO[i];
                }


            }
            return resultado;
        }

        string ponerBonito2(String textoO)
        {
            literales = new List<Literal>();
            string nuevoLiteral = "";
            int profundidad = 0;


            for (int i = 0; i < textoO.Length; i++)
            {
                nuevoLiteral += textoO[i];

                //if (textoO[i] != '(' && textoO[i] != ')')
                //{
                //    for (int j = 0; j < profundidad; j++)
                //        resultado += "    ";

                //    resultado += textoO[i];
                //}

                if (textoO[i] == '(')
                {
                    if (textoO.Length - i > 1 && textoO[i + 1] == ')')
                        continue;

                    literales.Add(new Literal(profundidad, nuevoLiteral,literales.Count+1));
                    profundidad++;
                    nuevoLiteral = "";


                    //nuevoLiteral += "\r\n";

                    for (int j = 0; j < profundidad; j++)
                        ;
                        //nuevoLiteral += "    ";


                }



                if (textoO[i] == ')')
                {
                    if (i - 1 >= 0 && textoO[i - 1] == '(')
                    {
                        nuevoLiteral = nuevoLiteral.Remove(nuevoLiteral.Length - 1);
                        literales.Add(new Literal(profundidad, nuevoLiteral, literales.Count + 1));
                        continue;
                    }
                            

                    nuevoLiteral = nuevoLiteral.Remove(nuevoLiteral.Length - 1);
                    if(nuevoLiteral.Trim().Length > 0)
                        literales.Add(new Literal(profundidad, nuevoLiteral, literales.Count + 1));
                    nuevoLiteral = "";

                    profundidad--;


                    for (int j = 0; j < profundidad; j++)
                        ;
                        //nuevoLiteral += "    ";
                    nuevoLiteral += textoO[i];

                    literales.Add(new Literal(profundidad, nuevoLiteral, literales.Count + 1));
                    nuevoLiteral = "";
                    
                }

                
            }

            if(nuevoLiteral != "")
                literales.Add(new Literal(0, nuevoLiteral, literales.Count + 1));

            //Renderizando
            tablaResultado.Rows.Clear();
            foreach (Literal literal in literales)
            {
                tablaResultado.Rows.Add(literal.profundidad, literal.ToString());
            }
            tablaResultado.ClearSelection();

            return nuevoLiteral;

            //Renderizando
            string idPadre = "";
            string idHijo = "";
            arbolLiterales.Nodes.Clear();

            foreach (Literal literal in literales)
            {
                if(idPadre == "")//nodos de primer nivel
                {
                    arbolLiterales.Nodes.Add(literal.id.ToString(), literal.texto);
                    idPadre = literal.id.ToString();
                }
                else if(idHijo == "")//
                {
                    arbolLiterales.Nodes[idPadre].Nodes.Add(literal.id.ToString(), literal.texto);
                    idHijo = literal.id.ToString();
                    profundidad++;
                }
                else
                {
                    if (profundidad == literal.profundidad)//es un hermano
                    {
                        arbolLiterales.Nodes[idPadre].Nodes.Add(literal.id.ToString(), literal.texto);
                        idHijo = literal.id.ToString();
                    }
                    else if(profundidad > literal.profundidad)//es un hijo
                    {
                        arbolLiterales.Nodes[idHijo].Nodes.Add(literal.id.ToString(), literal.texto);
                        idPadre = idHijo;
                        idHijo = literal.id.ToString();
                        profundidad++;
                    }
                    else if (profundidad < literal.profundidad)//es un tio
                    {

                    }
                    
                }
            }

            //TreeNode
            arbolLiterales.ExpandAll();

            return nuevoLiteral;
        }
    }
}
