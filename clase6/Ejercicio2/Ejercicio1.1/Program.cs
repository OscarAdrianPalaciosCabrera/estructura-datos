using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1._1
{
    class Program
    {

        static void Main(string[] args)
        {

            Queue cola = new Queue();
            int suma = 0;

            //agrego un elemento a la cola

            cola.Enqueue(1);
            cola.Enqueue(3);
            cola.Enqueue(5);
            cola.Enqueue(2);
            cola.Enqueue(4);


            while (cola.Count > 0)
                suma += (int)cola.Dequeue();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("La suma de los datos de la cola es: " + suma);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();




        }
    }
}
