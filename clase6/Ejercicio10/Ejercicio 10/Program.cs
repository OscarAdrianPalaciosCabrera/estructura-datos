using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {


            byte opc = 0;
            float valor;

            //----------Aqui definimos las pilas-------------

            Stack P = new Stack();
            Stack invert = new Stack();

            Console.WriteLine("Este programa permite recibir una pila P de numeros flotantes y devolver una pila con los valores de P invertidos");

            do
            {
                //----------Aqui mostramos el menu-------------

                Console.WriteLine("\n//////////////////////////////////////////////////////////////////////////////////////////\n");
                Console.WriteLine("Por favor digite una opcion del menu para continuar con el ejercicio\n\n    1)agregar dato a la pila P\n    2)Mostrar la pila P y la pila con los valires invertidos\n    3)Salir");
                opc = Convert.ToByte(Console.ReadLine());

                if (opc == 1)
                {
                    //----------Aqui Relleneamos la pila P-------------

                    Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////\n");
                    Console.WriteLine("Inserte un valor de tipo flotante para apilarlo en la pila P");
                    valor = Convert.ToSingle(Console.ReadLine());
                    P.Push(valor);
                }
                if (opc == 2)
                {
                    //----------Aqui rellenamos los datos de la pila P de forma invertida en un a nueva y mostramos las dos pilas-------------

                    Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////\n");
                    Console.WriteLine("La pila original P es:\n");
                    foreach (float i in P)
                    {
                        invert.Push(i);
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("\nLa pila con los valores invertidos es:\n");
                    foreach (float i in invert)
                        Console.WriteLine(i);

                    //----------Aqui limpiamos las pilas para reiniciar el ejercicio y eempezar de cero-------------
                    P.Clear();
                    invert.Clear();
                }
            } while (opc != 3);
        }
    }
}