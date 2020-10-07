using System;
using System.Collections;
using System.Text;

namespace EjercicioCola8
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            int num = 0;
            string ingresar = "";

            Queue cola1 = new Queue();
            Queue cola2 = new Queue();

            Console.WriteLine("Este programa permite recibir dos colas de numeros enteros e intercambiar sus datos");

            //----------menu de opciones------------ 
            do
            {
                Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("\nPor favor digite una opcion del menu para continuar con el ejercicio\n\n    1)agregar dato a la cola 1\n    2)Agregar dato a la cola 2\n    3)Mostrar la cola 1 con los elementos de la cola 2\n    4)Mostrar la cola 2 con los elementos de la cola 1\n    5)salir");
                ingresar = Console.ReadLine();
                op = Convert.ToInt32(ingresar);
                Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////");

                //-----------Rellenar la cola 2 con los datos de la cola 1--------------

                if (op == 1)
                {
                    Console.WriteLine("Introduzca algún numero ENTERO para agregarlo a la cola 1");
                    ingresar = Console.ReadLine();
                    num = Convert.ToInt32(ingresar);
                    cola2.Enqueue(num);
                }

                //-----------Rellenar la cola 1 con los datos de la cola 2------

                if (op == 2)
                {
                    Console.WriteLine("Introduzca algún numero ENTERO para agregarlo a la cola 2");
                    ingresar = Console.ReadLine();
                    num = Convert.ToInt32(ingresar);
                    cola1.Enqueue(num);
                }

                //-------------Mostramos la cola 1 con los elementos de la cola 2----------------

                if (op == 3)
                {                    
                    foreach(int i in cola1)
                        Console.WriteLine(i);                    
                }

                //-------------Mostramos la cola 2 con los elementos de la cola 1----------------

                if (op == 4)
                {
                    foreach (int i in cola2)
                        Console.WriteLine(i);
                }
            } while (op != 5);
        }
    }
}
