using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Ejercicio5
    {
        private int[,] matriz;
        private int[] vector;
        public void introducir()
        {
            matriz = new int[6, 8];
            Console.WriteLine("Este ejericio permite almacenar una matriz 6 x 8 introducida por teclado a un vector e imprimirlo\n");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////////");

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("Digite el elemento de la posicion [" + (i + 1) + "  " + (j + 1) + "]: ");
                    string ingresar;
                    ingresar = Console.ReadLine();
                    
                    matriz[i, j] = int.Parse(ingresar);
                }
            }
        }

        
        public void matavector()
        {
            vector = new int[48];
            int pos = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    vector[pos] = matriz[i, j];
                    pos++;
                }
            }
        }

        public void escribir()
        {
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////////\n");
            Console.Write("El vector resultante es:\n");
        
            for (int i = 0; i < 48; i++)
            {   
                Console.Write("["+vector[i]+"]\n");
            }                  
        }

        static void Main(string[] args)
        {
            Ejercicio5 ej = new Ejercicio5();
            ej.introducir();
            ej.matavector();
            ej.escribir();

        }

    }
            
}

