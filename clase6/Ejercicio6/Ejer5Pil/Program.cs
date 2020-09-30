using System;
using System.Collections;
using System.Collections.Generic;

namespace Ejer5Pil
{
    class Program
    {
        public class Ejemplo_11_02a
        {
           // .Escriba una rutina que reciba una Pila P de números enteros y mueva sus elementos
               //a una nueva Pila, pero invirtiendo el orden de salida de los mismos.Al finalizar la Pila P no
           //debe contener elementos

            public static void Main()
            {
                int num;

                Stack miPila = new Stack();
                miPila.Push(1);
                miPila.Push(2);
                miPila.Push(3);
                miPila.Push(4);
                miPila.Push(5);


                // Nueva Pila invertida

                for (byte i = 0; i < 5; i++)
                {
                    num = (int)miPila.Pop();
                    Console.WriteLine(num);
                }
            }
        }
    }
}
   
