using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArbolBinarioOrdenado2
{
    /*En este ejercicio vamos a crear una clase que permita insertar un entero en un árbol binario ordenado verificando que no se encuentre previamente dicho número.
     Para ello desarrollaremos los siguientes métodos:
    1 - Retornar la cantidad de nodos del árbol.
    2 - Retornar la cantidad de nodos hoja del árbol.
    3 - Imprimir en entre orden.
    4 - Imprimir en entre orden junto al nivel donde se encuentra dicho nodo.
    5 - Retornar la altura del árbol.
    6 - Imprimir el mayor valor del árbol.
    7 - Borrar el nodo menor del árbol.*/

    //Empezamos Creando a clase principal
    public class ArbolBinarioOrdenado
    {
        //Creamos una sub clase llamada Nodo
        class Nodo
        {
            //Declaramos las variables de tipo publicas que utilizaremos, haces publico el nodo, que tendra 2 variables; derecha e izquierda
            public int info;
            public Nodo izq, der;
        }
        //Declaramos las variables privadas de la clase ArbolBinarioOrdenado, Hacimos privado a Nodo que tendra la variable raiz
        private Nodo raiz;
        private int cant;
        private int altura;

        //utilizamos un constructor de la clase ArbolBinarioOrdenado para asignar a la variable raiz un valor null
        public ArbolBinarioOrdenado()
        {
            raiz = null;
        }
        //uTilizamos un metodo para insertar valores al arbol, dependiendo de la posicion del nodo; para ello utilizamos si condicionales
        public void Insertar(int info)
        {
            if (!Existe(info))
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
        }

        /*Para verificar si existe un elemento de información en el árbol disponemos un puntero reco en el nodo apuntado por raiz.
         * Dentro de un while verificamos si la información del parámetro coincide con la información del nodo apuntado por reco, 
         * en caso afirmativo salimos del método retornando true, en caso contrario si la información a buscar es mayor a la del
         * nodo procedemos a avanzar reco con la dirección del subárbol derecho:*/
        public bool Existe(int info)
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                if (info == reco.info)
                    return true;
                else
                    if (info > reco.info)
                    reco = reco.der;
                else
                    reco = reco.izq;
            }
            return false;
        }

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

        /*Para retornar la cantidad de nodos del árbol procedemos a inicializar un atributo de la clase llamado cant con cero.
         * Llamamos al método recursivo y en cada visita al nodo incrementamos el atributo cant en uno:*/
        private void Cantidad(Nodo reco)
        {
            if (reco != null)
            {
                cant++;
                Cantidad(reco.izq);
                Cantidad(reco.der);
            }
        }

        public int Cantidad()
        {
            cant = 0;
            Cantidad(raiz);
            return cant;
        }

        private void CantidadNodosHoja(Nodo reco)
        {
            if (reco != null)
            {
                if (reco.izq == null && reco.der == null)
                    cant++;
                CantidadNodosHoja(reco.izq);
                CantidadNodosHoja(reco.der);
            }
        }

        public int CantidadNodosHoja()
        {
            cant = 0;
            CantidadNodosHoja(raiz);
            return cant;
        }

        /*Para imprimir todos los nodos en entre orden junto al nivel donde se encuentra planteamos un método recursivo que llegue 
         * la referencia del nodo a imprimir junto al nivel de dicho nodo.Desde el método no recursivo pasamos la referencia a raiz
         * y un uno (ya que raiz se encuentra en el primer nivel) Cada vez que descendemos un nivel le pasamos la referencia del
         * subárbol respectivo junto al nivel que se encuentra dicho nodo:*/
        private void ImprimirEntreConNivel(Nodo reco, int nivel)
        {
            if (reco != null)
            {
                ImprimirEntreConNivel(reco.izq, nivel + 1);
                Console.Write(reco.info + " (" + nivel + ") - ");
                ImprimirEntreConNivel(reco.der, nivel + 1);
            }
        }

        public void ImprimirEntreConNivel()
        {
            ImprimirEntreConNivel(raiz, 1);
            Console.WriteLine();
        }

        //Implementamos un metodo que dependiendo del un si condicinal, para el caso de que reco sea valido nos retornara la altura
        private void RetornarAltura(Nodo reco, int nivel)
        {
            if (reco != null)
            {
                RetornarAltura(reco.izq, nivel + 1);
                if (nivel > altura)
                    altura = nivel;
                RetornarAltura(reco.der, nivel + 1);
            }
        }

        public int RetornarAltura()
        {
            altura = 0;
            RetornarAltura(raiz, 1);
            return altura;
        }

        /*Para imprimir el mayor valor del árbol debemos recorrer siempre por derecha hasta encontrar un nodo que almacene null en der:*/
        public void MayorValorl()
        {
            if (raiz != null)
            {
                Nodo reco = raiz;
                while (reco.der != null)
                    reco = reco.der;
                Console.WriteLine("Mayor valor del árbol:" + reco.info);
            }
        }

        /*Para borrar el menor valor del árbol lo primero que comprobamos es si el subárbol izquierdo es nulo luego el menor del árbol 
         * es el nodo apuntado por raiz.Luego si el subárbol izquierdo no está vacío procedemos a descender siempre por la izquierda 
         * llevando un puntero en el nodo anterior.Cuando llegamos al nodo que debemos borrar procedemos a enlazar el puntero izq del 
         * nodo que se encuentra en el nivel anterior con la referencia del subárbol derecho del nodo a borrar:*/
        public void BorrarMenor()
        {
            if (raiz != null)
            {
                if (raiz.izq == null)
                    raiz = raiz.der;
                else
                {
                    Nodo atras = raiz;
                    Nodo reco = raiz.izq;
                    while (reco.izq != null)
                    {
                        atras = reco;
                        reco = reco.izq;
                    }
                    atras.izq = reco.der;
                }
            }
        }

        //Utilizamos el metodo Main LLamar los diferentes metodos que se ejecutaran
        static void Main(string[] args)
        {
            //Instanciamos la clase ArbolBinarioOrdenado
            ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado();
            abo.Insertar(100);
            abo.Insertar(50);
            abo.Insertar(25);
            abo.Insertar(75);
            abo.Insertar(150);
            Console.WriteLine("Impresion entreorden: ");
            abo.ImprimirEntre();
            Console.WriteLine("Cantidad de nodos del árbol:" + abo.Cantidad());
            Console.WriteLine("Cantidad de nodos hoja:" + abo.CantidadNodosHoja());
            Console.WriteLine("Impresion en entre orden junto al nivel del nodo.");
            abo.ImprimirEntreConNivel();
            Console.Write("Artura del arbol:");
            Console.WriteLine(abo.RetornarAltura());
            abo.MayorValorl();
            abo.BorrarMenor();
            Console.WriteLine("Luego de borrar el menor:");
            abo.ImprimirEntre();
            Console.ReadKey();
        }
    }
}
}