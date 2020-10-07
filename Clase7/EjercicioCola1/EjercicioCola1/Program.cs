using System;
using System.Collections;
using System.Collections.Generic;

namespace EjercicioCola1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i;
            int num;
            int val;

            Queue miCola = new Queue();
            
            miCola.Enqueue(1);
            miCola.Enqueue(2);
            miCola.Enqueue(3);
            miCola.Enqueue(4);
            miCola.Enqueue(5);

            Console.WriteLine("Cola de enteros ordenada :");

            for ( i = 0; i < 5; i++)
            {
                num = (int)miCola.Dequeue();
                Console.WriteLine("");
                Console.WriteLine(num);
            }

            do
            {

                Console.WriteLine("Digite un numero :");
                val = int.Parse(Console.ReadLine());


            } while (val != 0);
            Console.WriteLine("");
            Console.WriteLine("Fin del programa"); 




        }
    }
}
