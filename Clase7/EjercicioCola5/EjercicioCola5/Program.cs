using System;
using System.Collections;
using System.Collections.Generic;

namespace EjercicioCola5
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue cola = new Queue();
            Stack Pila = new Stack();

            Pila.Push(1);
            Pila.Push(3);
            Pila.Push(5);
            Pila.Push(7);

            while (Pila.Count > 0)
                cola.Enqueue( (int) Pila.Pop());

            Console.WriteLine("Translado de los valores de la Pila a la Cola ");

        }
    }
}
