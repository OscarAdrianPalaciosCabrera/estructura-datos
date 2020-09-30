using System;
using System.Collections;
using System.Collections.Generic;

namespace EjercicioPil1
{
    class Program
    {
        public static void Main()
        {
            //Escriba una rutina que reciba una Pila P de números enteros y mueva sus elementos
            //a una nueva Pila, pero manteniendo el orden de salida de los mismos.


            int num;

            ArrayList P = new ArrayList();
            P.Add(1);
            P.Add(2);
            P.Add(3);
            P.Add(4);
            P.Add(5);

           
            //Impresion de la nueva lista manteniendo el orden

            for (int i = 0; i < P.Count; i++)
            {
                Console.WriteLine(P[i]);
            }
        }
    }
}
