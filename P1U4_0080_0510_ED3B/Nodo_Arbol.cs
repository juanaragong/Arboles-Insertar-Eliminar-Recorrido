using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1U4_0080_0510_ED3B
{
    internal class Nodo_Arbol
    {
        public int info;
        public Nodo_Arbol Izquierdo;
        public Nodo_Arbol Derecho;
        public Nodo_Arbol Padre;
        public int nivel;
        public int altura;
        public Rectangle Nodo;

        private const int Radio = 30;
        private const int DistanciaH = 80;
        private const int DistanciaV = 10;
        private int CoordenadaX;
        private int CoordenadaY;
        private Graphics col;
        private Arbol_Binario arbol;

        public Nodo_Arbol() { }

        public Nodo_Arbol(int infoNueva, Nodo_Arbol izquierdo, Nodo_Arbol derecho, Nodo_Arbol padre)
        {
            info = infoNueva;
            Izquierdo = izquierdo;
            Derecho = derecho;
            Padre = padre;
        }

        public Arbol_Binario Arbol
        {
            get { return arbol; }
            set { arbol = value; }
        }

        #region MetodosArbol
        public Nodo_Arbol Insertar(int valor, Nodo_Arbol nodoTemporal, int level) //funcion para insertar de forma recursiva en arbolbinario
        {
            if (nodoTemporal == null)
            {
                nodoTemporal = new Nodo_Arbol(valor, null, null, null)
                {
                    nivel = level
                };
            }
            else if (valor < nodoTemporal.info)
            {
                level++;
                nodoTemporal.Izquierdo = Insertar(valor, nodoTemporal.Izquierdo, level);
            }
            else if (valor > nodoTemporal.info)
            {
                level++;
                nodoTemporal.Derecho = Insertar(valor, nodoTemporal.Derecho, level);
            }
            else
            {
                MessageBox.Show("El dato ya existe.", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            return nodoTemporal;
        }

        public void Eliminar(int valor, ref Nodo_Arbol temporal) //funcion para elimnar nodo de arbolbinario
        {
            if (temporal != null) //si la raíz es distinta de null
            {
                if (valor < temporal.info) //si el valor a eliminar es menor que la raíz
                {
                    Eliminar(valor, ref temporal.Izquierdo);
                }
                else
                {
                    if (valor > temporal.info) //si el valor a eliminar es menor que la raíz
                    {
                        Eliminar(valor, ref temporal.Derecho);
                    }
                    else
                    {
                        Nodo_Arbol NodoEliminar = temporal; //se ubica el nodo a eliminar

                        if (NodoEliminar.Derecho == null)
                        {
                            temporal = NodoEliminar.Izquierdo;
                        }
                        else //se verifica si tiene hijo izquierdo
                        {
                            if (NodoEliminar.Izquierdo == null)
                            {
                                temporal = NodoEliminar.Derecho;
                            }
                            else
                            {
                                if (Alturas(temporal.Izquierdo) - Alturas(temporal.Derecho) > 0)
                                {
                                    //para veriicar que el hijo pasa a ser nueva raiz del subarbol
                                    Nodo_Arbol AuxiliarNodo = null;
                                    Nodo_Arbol Auxiliar = temporal.Izquierdo;
                                    bool bandera = false;
                                    while (Auxiliar.Izquierdo != null)
                                    {
                                        AuxiliarNodo = Auxiliar;
                                        Auxiliar = Auxiliar.Izquierdo;
                                        bandera = true;
                                    }
                                    //se crea nodo temporal
                                    temporal.info = Auxiliar.info;
                                    NodoEliminar = Auxiliar;
                                    if (bandera == true)
                                    {
                                        AuxiliarNodo.Izquierdo = Auxiliar.Derecho;
                                    }
                                    else
                                    {
                                        temporal.Derecho = Auxiliar.Derecho;
                                    }
                                }
                                else
                                {
                                    if (Alturas(temporal.Derecho) - Alturas(temporal.Izquierdo) == 0)
                                    {
                                        Nodo_Arbol AuxiliarNodo = null;
                                        Nodo_Arbol Auxiliar = temporal.Izquierdo;
                                        bool bandera = false;
                                        while (Auxiliar.Derecho != null)
                                        {
                                            AuxiliarNodo = Auxiliar;
                                            Auxiliar = Auxiliar.Derecho;
                                            bandera = true;
                                        }
                                        temporal.info = Auxiliar.info;
                                        NodoEliminar = Auxiliar;
                                        if (bandera == true)
                                        {
                                            AuxiliarNodo.Derecho = Auxiliar.Izquierdo;
                                        }
                                        else
                                        {
                                            temporal.Izquierdo = Auxiliar.Izquierdo;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("El nodo no existe en el árbol.","ERROR - ARBOL BINARIO",MessageBoxButtons.OK,MessageBoxIcon.Error );
            }
        } //final de la función eliminar

        public void Buscar (int valor,Nodo_Arbol temporal)
        {
            if(temporal != null)
            {
                if (valor == temporal.info) 
                {
                    MessageBox.Show("Nodo "+temporal.info+ " encontrado:\r\n\r\n" + "Coordenada X: " + temporal.CoordenadaX + "\r\n" + "Coordenada Y: " + temporal.CoordenadaY,"BUSQUEDA - ARBOL BINARIO",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    Encontrado(temporal);
                }
                else
                {
                    if (valor < temporal.info) Buscar(valor, temporal.Izquierdo); //busqueda en el subarbol izquierdo
                    else
                        if (valor > temporal.info) Buscar(valor, temporal.Derecho); //busqueda en el subarbol derecho
                }

            }
            else
            {
                MessageBox.Show("Nodo no encontrado ", "ERROR DE BUSQUEDA - ARBOL BINARIO", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public int ContarNodos() //metodo contar nodos del arbol
        {
            int conteo = 1; //iniciar contando el actual

            if (Izquierdo != null)
                conteo += Izquierdo.ContarNodos();
            if (Derecho != null)
                conteo += Derecho.ContarNodos();
            return conteo;
        }

        public int ObtenerProfundidad(int valor, int profundidad) //metdo para profundidad de un nodo a la raiz
        {
            if (info == valor)
            {
                return profundidad;
            }
            else if (valor < info && Izquierdo != null)
            {
                return Izquierdo.ObtenerProfundidad(valor, profundidad + 1);
            }
            else if (valor > info && Derecho != null)
            {
                return Derecho.ObtenerProfundidad(valor, profundidad + 1);
            }
            return -1;
        }
        #endregion

        #region DibujarArbol
        public void PosicionNodo(ref int xmin, int ymin) //funcion para posicion del nodo (donde se ha creado el dibujo del nodo)
        {
            int aux1, aux2;
            CoordenadaY = (int)(ymin + Radio / 2);

            if (Izquierdo != null) //obtiene la posicion del subarbol izquierdo
            {
                Izquierdo.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }
            if ((Izquierdo != null) && (Derecho != null))
            {
                xmin += DistanciaH;
            }

            if (Derecho != null) //si existe nodo derecho y el nodo izquierdo deja un espacio entre ellos
            {
                Derecho.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }

            if (Izquierdo != null && Derecho != null)
                CoordenadaX = (int)((Izquierdo.CoordenadaX + Derecho.CoordenadaX) / 2);
            else
            {
                if (Izquierdo != null)
                {
                    aux1 = Izquierdo.CoordenadaX;
                    Izquierdo.CoordenadaX = CoordenadaX - 80;
                    CoordenadaX = aux1;
                }
                else
                {
                    if (Derecho != null)
                    {
                        aux2 = Derecho.CoordenadaX;
                        //no hay nodo izquierdo, centrar en nodo derecho
                        Derecho.CoordenadaX = CoordenadaX + 80;
                        CoordenadaX = aux2;
                    }
                    else
                    {
                        CoordenadaX = (int)(xmin + Radio / 2); xmin += Radio;
                    }

                }
            }
        }

        public void DibujarRamas(Graphics grafo, Pen Lapiz) //función para dibujar las ramas de los nodos izquierdo y derecho
        {
            if (Izquierdo != null) //dibujar rama izquierda
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY,
                Izquierdo.CoordenadaX, Izquierdo.CoordenadaY);
                Izquierdo.DibujarRamas(grafo, Lapiz);
            }
            if (Derecho != null) //dibujar rama derecha
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY,
                Derecho.CoordenadaX, Derecho.CoordenadaY);
                Derecho.DibujarRamas(grafo, Lapiz);
            }

        }

        Color[] paletaColores = new Color[] //array para definir colores a cada nivel
        {
             ColorTranslator.FromHtml("#00050a"), //nivel 0
             ColorTranslator.FromHtml("#0e3245"), //nivel 1
             ColorTranslator.FromHtml("#0c5149"), //nivel 2
             ColorTranslator.FromHtml("#0a8967"), //nivel 3
             ColorTranslator.FromHtml("#09c184"), //nivel 4
             ColorTranslator.FromHtml("#9dbfaf") //nivel 5
        };

        public void DibujarNodo(Graphics grafo, Font fuente, Brush RellenoFuente, Pen Lapiz, Brush encuentro)
        {
            col = grafo;
            Color colorRelleno;

            if (nivel < paletaColores.Length)
            {
                colorRelleno = paletaColores[nivel]; //si esta dentro del rango de colores usarlo
            }
            else
            {
                colorRelleno = ColorTranslator.FromHtml("#a2a9af"); //sino usar gris por defecto
            }
            using (Brush brushRelleno = new SolidBrush(colorRelleno)) //pincel para rellenar el nodo 
            {
                Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);  //contorno del nodo
                grafo.FillEllipse(brushRelleno, rect); //relleno del nodo en la elipse
                grafo.DrawEllipse(Lapiz, rect); //borde del nodo en la elipse
                StringFormat formato = new StringFormat //dibujar el nombre del nodo osea  el contenido
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                grafo.DrawString(info.ToString(), fuente, RellenoFuente, CoordenadaX, CoordenadaY, formato);
            }

            //dibujar los nodos hijos
            if (Izquierdo != null) Izquierdo.DibujarNodo(grafo, fuente, RellenoFuente, Lapiz, encuentro);
            if (Derecho != null) Derecho.DibujarNodo(grafo, fuente, RellenoFuente, Lapiz, encuentro);
        }
        #endregion

        private static int Alturas(Nodo_Arbol temporal) //verificar altura del árbol
        {
            return temporal == null ? -1 : temporal.altura;
        }

        public void Encontrado(Nodo_Arbol temporal) //verificar si se encuentra el nodo
        {
            Rectangle rec = new Rectangle(temporal.CoordenadaX, temporal.CoordenadaY, 40, 40);
        }

    }
}
