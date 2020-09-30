using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EjercicioLis3
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList Ent = new ArrayList();

            Ent.Add(5);
            Ent.Add(4);
            Ent.Add(1);
            Ent.Add(3);
            Ent.Add(2);

            imprime(Ent);
            Console.WriteLine("");
            Console.WriteLine("El primer elemento en la direccion 1 es {0}" , Ent[1]);
            Console.WriteLine("");

        }

        private static void imprime(ArrayList Ent)
        {
            foreach (int n in Ent)
                Console.Write(" {0}, ", n);
            Console.WriteLine("\n-----------------------");
        }
    }
}
