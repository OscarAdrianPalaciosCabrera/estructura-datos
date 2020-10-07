using System;
using System.Collections;
using System.Text;

namespace EjercicioCola10
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            float num = 0;
            string ingresar = "";

            Queue cola1 = new Queue();
            Queue colanueva = new Queue();

            Console.WriteLine("Este programa permite recibir una cola de numeros flotantes y mover sus elementos a una nueva cola, pero invirtiendo sus datos");

            //----------menu de opciones------------ 
            do
            {
                Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("\nPor favor digite una opcion del menu para continuar con el ejercicio\n\n    1)agregar dato a la cola \n    2)Mostrar la nueva cola\n    3)Salir");
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

                if (op == 2)
                {
                    //-----------Mover los elementos de la cola 1 a la nueva cola e invertirlos------

                    foreach (float i in cola1)
                        colanueva.Enqueue(i);

                    //-----------Mostrar los elementos de la nueva cola invertidos------

                    Console.WriteLine("Esta es la cola nueva con los elementos de la cola 1 invertidos:");
                    for (float i = colanueva.Count; i >= 1; i--)
                        Console.WriteLine(i);
                }
            } while (op != 3);
        }
    }
}
