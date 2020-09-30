using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            byte opc = 0;
            float valor;

            //-----------Aqui definimos las pilas----------------

            Stack P = new Stack();
            Stack duplic = new Stack();

            Console.WriteLine("Este programa permite recibir una pila P de numeros enteros y devolver otra pila exactamente igual");

            do
            {
                //-----------Aqui mostramos el menu----------------

                Console.WriteLine("\n//////////////////////////////////////////////////////////////////////////////////////////\n");
                Console.WriteLine("Por favor digite una opcion del menu para continuar con el ejercicio\n\n    1)agregar dato a la pila P\n    2)Mostrar la pila P y la pila duplicada (exactamente igual)\n    3)Salir");
                opc = Convert.ToByte(Console.ReadLine());

                if (opc == 1)
                {
                    //-----------Aqui rellenamos la pila y hacemos un duplicado----------------

                    Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////\n");
                    Console.WriteLine("Inserte un valor de tipo entero para apilarlo en la pila P");
                    valor = Convert.ToSingle(Console.ReadLine());
                    P.Push(valor);
                    duplic.Push(valor);
                }
                if (opc == 2)
                {
                    //-----------Aqui mostramos las dos pilas----------------

                    Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////\n");
                    Console.WriteLine("La pila original P es:\n");
                    foreach (float i in P)
                    {                        
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("\nLa pila duplicado es la siguiente \n");
                    foreach (float i in duplic)
                        Console.WriteLine(i);

                    //----------Aqui limpiamos las pilas para reiniciar el ejercicio y eempezar de cero-------------

                    P.Clear();
                    duplic.Clear();
                }
            } while (opc != 3);
        }
    }
}
