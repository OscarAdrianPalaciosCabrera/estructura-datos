using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definimos nuestras listas
            byte op = 0;
            ArrayList lista1 = new ArrayList();
            ArrayList lista2 = new ArrayList();
            Console.WriteLine("Este programa permite ingresar dos listas de numeros entero, concatenarlas y mostrar el resultado");
            do
            {
                Console.WriteLine("\n//////////////////////////////////////////////////////////////////////////////////////////\n");
                Console.WriteLine("Por favor digite una opcion valida del menu para continuar con el ejercicio\n\n    1)Agregar dato a la lista 1\n    2)Agregar dato a la lista 2\n    3)Mostrar los elementos de las dos listas concatenados\n    4)Salir");
                op = Convert.ToByte(Console.ReadLine());

                if (op == 1)
                {
                    //-----------Aqui rellenamos la lista 1---------------

                    Console.WriteLine("\n//////////////////////////////////////////////////////////////////////////////////////////\n");
                    Console.WriteLine("por favor inserte valor a la lista 1");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    lista1.Add(valor);
                }
                if (op == 2)
                {
                    //-----------Aqui rellenamos la lista 2---------------

                    Console.WriteLine("\n//////////////////////////////////////////////////////////////////////////////////////////\n");
                    Console.WriteLine("por favor inserte valor a la lista 2");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    lista2.Add(valor);
                }
                if (op == 3)
                {
                    Console.WriteLine("\n//////////////////////////////////////////////////////////////////////////////////////////\n");
                    Console.WriteLine("Aqui estan las dos listas concatenadas en su respectivo orden");

                    //-----------Aqui concatenamos ordenadamente los elementos de la lista 1 y la lista en ese orden----------------

                    foreach (int i in lista2)
                        lista1.Add(i);
                    foreach (int i in lista1)
                        Console.Write("   {0}\n",i);

                    Console.WriteLine("\n//////////////////////////////////////////////////////////////////////////////////////////\n");
                    Console.WriteLine("------Ejercicio terminado------Si desea puede seguir rellenando las listas y concatenandolas");

                }
            } while (op != 4);
        }
           
    }
}
