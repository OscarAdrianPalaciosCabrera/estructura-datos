using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, op=0;
            ArrayList lista1 = new ArrayList();
            ArrayList lista2 = new ArrayList();
            Console.WriteLine("Este programa permite ingresar dos listas (lista 1 y lista 2), intercambiar los datos entre ambas listas sin alterar el orden y mostrar el resultado");

            do
            {
                
                Console.WriteLine("\n//////////////////////////////////////////////////////////////////////////////////////////\n");
                Console.WriteLine("Por favor digite una opcion valida del menu para continuar con el ejercicio\n\n    1)Agregar dato a la lista 1\n    2)Agregar dato a la lista 2\n    3)Mostrar los elementos de la lista 1 en la 2 y biseversa\n    4)Salir");
                op = Convert.ToByte(Console.ReadLine());

                if (op == 1)
                {
                    //-----------aqui rellenamos la lista 2 con los valores de la lista 1---------------

                    Console.WriteLine("\n//////////////////////////////////////////////////////////////////////////////////////////\n");
                    Console.WriteLine("por favor inserte valor a la lista 1");
                    valor = Convert.ToInt32(Console.ReadLine());
                    lista2.Add(valor);
                } 
                if (op == 2)
                {
                    //-----------aqui rellenamos la lista 1 con los valores de la lista2---------------

                    Console.WriteLine("\n//////////////////////////////////////////////////////////////////////////////////////////\n");
                    Console.WriteLine("por favor inserte valor a la lista 2");
                    valor = Convert.ToInt32(Console.ReadLine());
                    lista1.Add(valor);
                }
                if (op == 3)
                {
                    Console.WriteLine("\n//////////////////////////////////////////////////////////////////////////////////////////\n");
                    Console.WriteLine("Esta es la lista 1 con los valores de la lista 2:");
                    foreach (int i in lista1)
                    {     
                        Console.Write("   {0}", i);
                    }
                    Console.WriteLine("\n//////////////////////////////////////////////////////////////////////////////////////////\n");
                    Console.WriteLine("Esta es la lista 2 con los valores de la lista 1:");

                    foreach (int i in lista2)
                    {
                        Console.Write("   {0}", i);
                    }
                }
            } while (op != 4);            
        }
    }
}
