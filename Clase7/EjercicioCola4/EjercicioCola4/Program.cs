using System;
using System.Collections;
using System.Collections.Generic;

namespace EjercicioCola4
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue cola = new Queue();
            Queue cola1 = new Queue();
            Queue cola2 = new Queue();

            cola.Enqueue(1);
            cola.Enqueue(2);
            cola.Enqueue(3);

            //Segunda cola

            cola1.Enqueue(4);
            cola1.Enqueue(5);
            cola1.Enqueue(6);

            while (cola.Count > 0)
                cola2.Enqueue((int)cola.Dequeue());

            while (cola1.Count > 0)
                cola2.Enqueue((int)cola1.Dequeue());

            while (cola2.Count > 0)
                Console.WriteLine(" " + (int)cola2.Dequeue() + "\n");



        }
    }
}
