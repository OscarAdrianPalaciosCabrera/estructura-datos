using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//A continuación desarrollamos una clase para la administración de un árbol binario ordenado.

namespace ArbolBinarioOrdenado1
{

    /*Creamos un nodo y disponemos los punteros izq y der a null, 
     guardamos la información que llega al método en el nodo.


    Si el árbol está vacío, apuntamos raíz al nodo creado; en caso de no estar vacío, 
    dentro de una estructura repetitiva vamos comparando info con la información del nodo, 
    si info es mayor a la del nodo descendemos por el subárbol derecho en caso contrario descendemos por el 
    subárbol izquierdo.


    Cuando se encuentra un subárbol vacío insertar el nodo en dicho subárbol.
    Para esto llevamos un puntero anterior dentro del while.*/


    public class ArbolBinarioOrdenado
    {
        class Nodo
        {
            public int info;
            public Nodo izq, der;
        }
        Nodo raiz;

        public ArbolBinarioOrdenado()
        {
            raiz = null;
        }

        public void Insertar(int info)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null)
                raiz = nuevo;
            else
            {
                Nodo anterior = null, reco;
                reco = raiz;
                while (reco != null)
                {
                    anterior = reco;
                    if (info < reco.info)
                        reco = reco.izq;
                    else
                        reco = reco.der;
                }
                if (info < anterior.info)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
            }
        }

 //---------------------------------------------------------------------------------------------------------

 /*El método ImprimirPre(), es decir el no recursivo se encarga de llamar al método recursivo pasando la dirección
  del nodo raiz.

  El método recursivo void ImprimirPre (Nodo reco) lo primero que verifica con un if si reco está apuntando a un nodo
  (esto es verdad si reco es distinto a null), en caso afirmativo ingresa al bloque del if y realiza:
             - Visitar la raiz.
             - Recorrer el subárbol izquierdo en pre-orden.
             - Recorrer el subárbol derecho en pre-orden.

  La visita en este caso es la impresión de la información del nodo y los recorridos son las llamadas 
  recursivas pasando las direcciones de los subárboles izquierdo y derecho.

 Los algoritmos de los recorridos en entreorden y postorden son similares. 
 La diferencia es que la visita la realizamos entre las llamadas recursivas en el recorrido en entre orden:*/

        private void ImprimirPre(Nodo reco)
        {
            if (reco != null)
            {
                Console.Write(reco.info + " ");
                ImprimirPre(reco.izq);
                ImprimirPre(reco.der);
            }
        }
        public void ImprimirPre()
        {
            ImprimirPre(raiz);
            Console.WriteLine();
        }

//-------------------------------------------------------------------------------------------------------------


/*y por último en el recorrido en postorden la visita la realizamos luego de las dos llamadas recursivas:*/


        private void ImprimirEntre(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirEntre(reco.izq);
                Console.Write(reco.info + " ");
                ImprimirEntre(reco.der);
            }
        }

        public void ImprimirEntre()
        {
            ImprimirEntre(raiz);
            Console.WriteLine();
        }


        private void ImprimirPost(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirPost(reco.izq);
                ImprimirPost(reco.der);
                Console.Write(reco.info + " ");
            }
        }


        public void ImprimirPost()
        {
            ImprimirPost(raiz);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado();
            abo.Insertar(100);
            abo.Insertar(50);
            abo.Insertar(25);
            abo.Insertar(75);
            abo.Insertar(150);
            Console.WriteLine("Impresion preorden: ");
            abo.ImprimirPre();
            Console.WriteLine("Impresion entreorden: ");
            abo.ImprimirEntre();
            Console.WriteLine("Impresion postorden: ");
            abo.ImprimirPost();
            Console.ReadKey();
        }
    }
}