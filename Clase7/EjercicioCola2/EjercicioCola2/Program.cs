using System;
using System.Collections;
using System.Collections.Generic;

namespace EjercicioCola2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue cola = new Queue();
            int suma = 0;
            int num;
            int i;

            //agrego elementos a la cola

            cola.Enqueue(1);
            cola.Enqueue(3);
            cola.Enqueue(7);
            cola.Enqueue(2);
            cola.Enqueue(4);


            while (cola.Count > 0)
                suma += (int)cola.Dequeue();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("La suma de los datos de la cola es de : " + suma);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
