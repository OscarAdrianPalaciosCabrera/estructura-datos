using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EjercicioLis1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
               
                List<int> ListVal = new List<int>();

            ListVal.Add(1);
            ListVal.Add(2);
            ListVal.Add(3);
            ListVal.Add(4);
            ListVal.Add(5);
            ListVal.Add(0);

            Console.WriteLine("");
            Console.WriteLine("Lista ordenada ");
            Console.WriteLine("");


            for (i = 0; i < ListVal.Count(); i++)
            {

                Console.WriteLine(ListVal[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Cero detectado, Fin del programa");

        }
    }
}
