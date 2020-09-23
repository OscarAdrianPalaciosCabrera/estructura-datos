using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Matriz2
{
    class Matriz2
    {
        public int[] suma = new int[7];
        private int[,] mat;

        // Primer método: Cargar la matriz

        public void Met1()
        {
            // Definimos la matriz de 7*7

            mat = new int[7, 7];


            // Procedemos a llenar la matriz

            for (int f = 0; f < 7; f++)
            {
                for (int c = 0; c < 7; c++)
                {
                    Console.Write("       Ingrese el elemento [" + (f + 1) + "  " + (c + 1) + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);

                }
            }

        }

        public void Met2()
        {
            Console.WriteLine(" ");
            Console.WriteLine("   La matriz resultante es");
            Console.WriteLine(" ");


            for (int f = 0; f < 7; f++)
            {
                for (int c = 0; c < 7; c++)
                {
                    Console.Write("    " + mat[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void Met3()
        {
            Console.WriteLine(" ");
            Console.WriteLine("   La suma de la matriz es");
            Console.WriteLine(" ");


            for (int f = 0; f < 7; f++)
            {
                for (int c = 0; c < 7; c++)
                {
                    Console.Write("    " + suma[(f + 1 + c + 1)] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

            static void Main(string[] args)
            {
                Matriz2 ma = new Matriz2();
                ma.Met1();
                ma.Met2();
                ma.Met3();
            }
        }

    }



