using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class program
    {
        static void Main(string[] args)
        {
            int[,] M1;
            int[,] M2;
            int[,] MR;

            Console.WriteLine("Este ejericio permite sumar una matriz (M1) con una matriz (M2) y mostrar el resultado en una tercera Matriz (MR)\n");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////////");
            int f, c;

            Console.WriteLine("¿Cuantas filas van a tener sus Matrices?");
            string entrada;
            entrada = Console.ReadLine();
            f = Convert.ToInt32(entrada);

            Console.WriteLine("¿Cuantas columnas van a tener sus Matrices?");
            string entrada1;
            entrada1 = Console.ReadLine();
            c = Convert.ToInt32(entrada1);
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////////");
            //se rellena la matriz M1
            M1 = new int[f, c];
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("Digite el elemento de la posicion [" + (i + 1) + "  " + (j + 1) + "] de su matriz M1 ");
                    string ingresar;
                    ingresar = Console.ReadLine();

                    M1[i, j] = int.Parse(ingresar);
                }
            }

            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("ahora rellenaremos la matriz M2");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////");

            //se rellena la matriz M2 y se suman M1 y M2
            M2 = new int[f, c];
            MR = new int[f, c];
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("Digite el elemento de la posicion [" + (i + 1) + "  " + (j + 1) + "] de su matriz M2 ");
                    string ingresar;
                    ingresar = Console.ReadLine();

                    M2[i, j] = int.Parse(ingresar);
                    MR[i, j] = M2[i, j] + M1[i, j];
                }
            }            
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////");

            //se escribe el resultado de la suma
            Console.WriteLine("La matriz (MR), resultante de la suma entre M1 y M2 es:\n\nMR");

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("    " + MR[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }   
    }
}
