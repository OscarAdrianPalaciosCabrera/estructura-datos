using System;
using System.Collections;
using System.Collections.Generic;

namespace EjercicioCola9
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            int num = 0;
            string ingresar = "";

            Queue cola1 = new Queue();
            Queue copia = new Queue();

            Console.WriteLine("Este programa permite recibir una cola de numeros enteros y hacer una copia exacta de la misma");

            //----------menu de opciones------------ 
            do
            {
                Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("\nPor favor digite una opcion del menu para continuar con el ejercicio\n\n    1)agregar dato a la cola 1 \n    2)Mostrar la copia\n    3)Salir");
                ingresar = Console.ReadLine();
                op = Convert.ToInt32(ingresar);
                Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////");

                //-----------Rellenar la cola 1--------------

                if (op == 1)
                {
                    Console.WriteLine("Introduzca algún numero ENTERO para agregarlo a la cola 1");
                    ingresar = Console.ReadLine();
                    num = Convert.ToInt32(ingresar);
                    cola1.Enqueue(num);
                }

                //-----------Hacer una copia de la cola una e imprimirla------

                if (op == 2)
                {

                    foreach (int i in cola1)
                        copia.Enqueue(i);

                    Console.WriteLine("Esta es la copia de la cola 1");
                    foreach (int i in copia)                    
                        Console.WriteLine(i);
                    
                }
            } while (op != 3);
        }
    }
}
