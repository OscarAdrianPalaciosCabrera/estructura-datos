using System;
using System.Collections;
using System.Text;

namespace EjercicioCola7
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            float num = 0;
            string ingresar = "";

            Queue cola1 = new Queue();
            Queue cola2 = new Queue();

            Console.WriteLine("Este programa permite recibir dos colas de numeros flotantes y ubicar los datos de ambas colas en otra resultante");

            //----------menu de opciones------------ 
            do
            {
                Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("\nPor favor digite una opcion del menu para continuar con el ejercicio\n\n    1)agregar dato a la cola 1\n    2)Agregar dato a la cola 2\n    3)Mostrar la cola resultante\n    4)Salir");
                ingresar = Console.ReadLine();
                op = Convert.ToInt32(ingresar);
                Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////");

                //-----------Rellenar la cola 1--------------

                if (op == 1)
                {
                    Console.WriteLine("Introduzca algún numero FLOTANTE para agregarlo a la cola 1");
                    ingresar = Console.ReadLine();
                    num = Convert.ToSingle(ingresar);
                    cola1.Enqueue(num);   
                }

                //-----------Rellenar la cola 2------

                if (op == 2)
                {
                    Console.WriteLine("Introduzca algún numero FLOTANTE para agregarlo a la cola 2");
                    ingresar = Console.ReadLine();
                    num = Convert.ToSingle(ingresar);
                    cola2.Enqueue(num);
                }

                //-------------Ponemos los elementos de las dos colas en na nueva----------------

                if (op == 3)
                {
                    Console.WriteLine("La cola resultante despues de combinar la Cola 1 y 2 es:");

                    foreach (float i in cola1)
                        Console.WriteLine("     {0}", i);

                    foreach (float i in cola2)
                        Console.WriteLine("     {0}", i);

                }
            } while (op != 4);
        }
    }
}
