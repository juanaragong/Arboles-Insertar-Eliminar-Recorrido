using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P1U4_0080_0510_ED3B
{
    internal class Arbol_Binario
    {
        public Nodo_Arbol Raiz;
        public Nodo_Arbol aux;
        public int x1 = 400;  //posiciones iniciales de la raíz del árbol
        public int y2 = 75; // función para Colorear los nodos

        public Arbol_Binario()
        {
            aux = new Nodo_Arbol();
        }
        public Arbol_Binario(Nodo_Arbol nueva_raiz)
        {
            Raiz = nueva_raiz;
        } //funcion para agregar nuevo nodo (valor) al arbol binario

        #region MetodosArbol
        public void Insertar(int valor)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(valor, null, null, null)
                {
                    nivel = 0
                };
            }
            else
                Raiz = Raiz.Insertar(valor, Raiz, Raiz.nivel);
        }

        public void Eliminar(int valor)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(valor, null, null, null);
            }
            else
                Raiz.Eliminar(valor,ref Raiz);
        }

        public void Buscar(int valor)
        {
            if (Raiz != null)
            {
                Raiz.Buscar(valor, Raiz);
            }
        }

        public bool BuscarExisteNodo(int valor)
        {
            return ExisteNodo(Raiz, valor);
        }
        //metodos para comprobar si el nodo existe o no para su eliminacion
        private bool ExisteNodo(Nodo_Arbol nodo, int valor)
        {
            if (nodo == null)
            {
                return false; //si nodo nulo entonces no existe
            }
            if (nodo.info == valor)
            {
                return true; // si valor nodo coincide entonces si existe
            }

            if (valor < nodo.info)
            {
                return ExisteNodo(nodo.Izquierdo, valor);
            }
            else
            {
                return ExisteNodo(nodo.Derecho, valor);
            }
        }

        public int ObtenerAltura(Nodo_Arbol nodo) //metodo obtener la altura total del abrol
        {
            if (nodo == null)
            {
                return 0;
            }
            else
            {
                int alturaIzquierda = ObtenerAltura(nodo.Izquierdo);
                int alturaDerecha = ObtenerAltura(nodo.Derecho);
                //devolver la altura máxima entre los subárboles izq-der y sumar 1 para contar el nodo actual
                return Math.Max(alturaIzquierda, alturaDerecha) + 1;
            }
        }

        public int ContarTotalNodos()
        {
            if (Raiz == null)
                return 0;
            else
                return Raiz.ContarNodos();
        }

        public int ObtenerProfundidad(int valor)
        {
            if (Raiz == null)
            {
                return -1;
            }
            return Raiz.ObtenerProfundidad(valor, 0);
        }

        public int SumarNodos(Nodo_Arbol nodo)
        {
            if(nodo == null) { return 0; }
                return nodo.info + SumarNodos(nodo.Derecho) + SumarNodos(nodo.Izquierdo);
        }

        public void Vaciar()
        {
            VaciarArbolito(Raiz);
            Raiz = null;
        }

        private void VaciarArbolito(Nodo_Arbol nodo)
        {
            if (nodo == null) return;
            VaciarArbolito(nodo.Izquierdo);
            VaciarArbolito(nodo.Derecho);
            nodo.Izquierdo = null;
            nodo.Derecho = null;
        }

        public string recorrer (bool inor, bool post, bool pre)
        {
            string Resultado = "";
            if (inor) RecorridoInorden(Raiz, ref Resultado);
            if (post) RecorridoPostOrden(Raiz, ref Resultado);
            if (pre) RecorridoPreOrden(Raiz, ref Resultado);
            return Resultado;
        }

        public void RecorridoInorden(Nodo_Arbol NodoActual, ref string Resultado)
        {
            if (NodoActual != null)
            {
                RecorridoInorden(NodoActual.Izquierdo, ref Resultado); //llamada recursiva a recorrer inOrden en subarbol izquierdo
                Resultado = Resultado + "->" + NodoActual.info.ToString(); //visita nodo actual
                RecorridoInorden(NodoActual.Derecho, ref Resultado); //llamada recursiva a recorrer inOrden en subarbol derecho
            }
        }

        public void RecorridoPostOrden(Nodo_Arbol NodoActual, ref string Resultado)
        {
            if (NodoActual != null)
            {
                RecorridoPostOrden(NodoActual.Izquierdo, ref Resultado); //llamada recursiva a recorrer inOrden en subarbol izquierdo
                RecorridoPostOrden(NodoActual.Derecho, ref Resultado); //llamada recursiva a recorrer inOrden en subarbol derecho
                Resultado = Resultado + "->" + NodoActual.info.ToString(); //visita nodo actual 
            }
        }
        public void RecorridoPreOrden(Nodo_Arbol NodoActual, ref string Resultado)
        {
            if (NodoActual != null)
            {
                Resultado = Resultado + "->" + NodoActual.info.ToString(); //visita nodo actual
                RecorridoPreOrden(NodoActual.Izquierdo, ref Resultado); //llamada recursiva a recorrer inOrden en subarbol izquierdo
                RecorridoPreOrden(NodoActual.Derecho, ref Resultado); //llamada recursiva a recorrer inOrden en subarbol derecho
            }
        }

        #endregion

        #region EsquemaArbol
        public void DibujarArbol(Graphics grafo, Font fuente, Pen Lapiz, Brush encuentro)
        {
            int x = 300; //posiciones de la raíz del árbol
            int y = 45;
            if (Raiz == null)
                return;

            Raiz.PosicionNodo(ref x, y); //posición de cada nodo
            Raiz.DibujarRamas(grafo, Lapiz); //dibuja los enlaces entre nodos
            Raiz.DibujarNodo(grafo, fuente, Brushes.White, Lapiz, encuentro);
        }
        #endregion

    }
}
