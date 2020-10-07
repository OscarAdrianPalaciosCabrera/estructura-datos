using System;
using System.Collections;
using System.Collections.Generic;

namespace EjercicioCola3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Queue cola = new Queue();

            cola.Enqueue(3);
            cola.Enqueue(6);
            cola.Enqueue(4);
            cola.Enqueue(1);
            cola.Enqueue(2);

           for (i = 1; i <= 1; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Elementos totales que se encuentran en la cola: " + cola.Count);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("El elemento que esta en la dirección 1 de la cola es: " + cola.Peek());
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }
    }
}
