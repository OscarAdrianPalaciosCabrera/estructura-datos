using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ejercicio 3).
            Desarrollar un algoritmo que genere las tablas de multiplicar del 1 al 10.*/

            int i, j;
            Console.WriteLine("Estas son las tablas de multiplicar del 1 al 10\n");
            
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("\nTabla del {0}\n", i);
                for (j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0}X{1}={2}", i, j, (i * j));
                }                
            }            
        }
    }
}
