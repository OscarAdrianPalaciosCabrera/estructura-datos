using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            float num = 0;
            string ingresar="";
            

            Stack P1 = new Stack();
            Stack P2 = new Stack();
            
            Console.WriteLine("Este programa permite recibir dos pilas de numeros flotantes y apilarlas en una resultante de tipo LIFO");
                 
            //----------menu de opciones------------ 
            do
            {
                Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("\nPor favor digite una opcion del menu para continuar con el ejercicio\n\n    1)agregar dato a la pila P1\n    2)Agregar dato a la pila P2\n    3)Mostrar la pila resultante despues de apilar P1 y P2");
                ingresar = Console.ReadLine();
                op = Convert.ToInt32(ingresar);
                Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////");

                //-----------Rellenar la pila P1--------------

                if (op == 1)
                {
                    Console.WriteLine("Introduzca algún numero FLOTANTE para agregarlo a la pila P1");
                    ingresar = Console.ReadLine();
                    num = Convert.ToSingle(ingresar);
                    P1.Push(num);
                }

                //-----------Rellenar la pila P2-------------

                if (op == 2)
                {
                    Console.WriteLine("Introduzca algún numero FLOTANTE para agregarlo a la pila P2");
                    ingresar = Console.ReadLine();
                    num = Convert.ToSingle(ingresar);
                    P2.Push(num);
                }

                //-------------Mostrar las dos pilas apiladas------------

                if (op == 3)
                {
                    Console.WriteLine("La pila resultante despues de apilar P1 y P2 es:");

                    foreach (float i in P2)
                        Console.WriteLine("  {0}", i);
                                           
                    foreach (float i in P1)
                        Console.WriteLine("  {0}", i);                        
                }
               
            } while (op != 4);
        }
    }
}

