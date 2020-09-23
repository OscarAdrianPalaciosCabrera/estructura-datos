using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Matriz1
{
    class Matriz1
    {

        private int[,] mat;

        // Primer método: Cargar la matriz

        public void Met1()
        {
            // Definimos la matriz de 5*6

            mat = new int[5, 6];

            // Procedemos a llenar la matriz

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 6; c++)
                {
                    Console.Write(" Ingrese un numero para la ubicacion [" + (f + 1) + "  " + (c + 1) + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }

        public void Met2()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" La matriz resultante es ");
            Console.WriteLine(" ");


            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 6; c++)
                {
                    Console.Write("    " + mat[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Matriz1 ma = new Matriz1();
            ma.Met1();
            ma.Met2();
        }
    }
}
