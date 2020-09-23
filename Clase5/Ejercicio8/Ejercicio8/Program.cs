using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class program
    {
        static void Main(string[] args)
        {
            int[,] M1;
            int[,] M2;
            int[,] MP;
            int fmat1, cmat1;

            Console.WriteLine("Este ejericio permite multiplicar una matriz (M1) con una matriz (M2) y mostrar el resultado en una tercera Matriz (MP)\n");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////////");

            Console.WriteLine("¿Cuantas filas va a tener sus matriz M1?\nRecuerde que para multiplicar matrices el numero columnas de la primer matriz debe coincidor con el numero de filas de la segunda matriz");
            string entrada;
            entrada = Console.ReadLine();
            fmat1 = Convert.ToInt32(entrada);

            Console.WriteLine("¿Cuantas columnas va a tener su Matrices M1?\nRecuerde que para multiplicar matrices el numero columnas de la primer matriz debe coincidor con el numero de filas de la segunda matriz");
            string entrada1;
            entrada1 = Console.ReadLine();
            cmat1 = Convert.ToInt32(entrada1);
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////////");

            //se rellena la matriz M1
            M1 = new int[fmat1, cmat1];
            for (int i = 0; i < fmat1; i++)
            {
                for (int j = 0; j < cmat1; j++)
                {
                    Console.Write("Digite el elemento de la posicion [" + (i + 1) + "  " + (j + 1) + "] de su matriz M1 ");
                    string ingresar;
                    ingresar = Console.ReadLine();

                    M1[i, j] = int.Parse(ingresar);
                }
            }

            int fmat2, cmat2;
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("ahora rellenaremos la matriz M2");
            Console.WriteLine("¿Cuantas filas va a tener sus matriz M2?\nRecuerde que para multiplicar matrices el numero columnas de la primer matriz debe coincidor con el numero de filas de la segunda matriz");
            string entrada2;
            entrada2 = Console.ReadLine();
            fmat2 = Convert.ToInt32(entrada2);

            Console.WriteLine("¿Cuantas columnas va a tener su Matrices M2?\nRecuerde que para multiplicar matrices el numero columnas de la primer matriz debe coincidor con el numero de filas de la segunda matriz");
            string entrada3;
            entrada3 = Console.ReadLine();
            cmat2 = Convert.ToInt32(entrada3);
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////");

            if (cmat1 == fmat2)
            {
                //se rellena la matriz M2 
                M2 = new int[fmat2, cmat2];
                for (int i = 0; i < fmat2; i++)
                {
                    for (int j = 0; j < cmat2; j++)
                    {
                        Console.Write("Digite el elemento de la posicion [" + (i + 1) + "  " + (j + 1) + "] de su matriz M2 ");
                        string ingresar;
                        ingresar = Console.ReadLine();

                        M2[i, j] = int.Parse(ingresar);
                    }
                }
                Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////");

                //se multiplican las matrices
                int incrementar;
                MP = new int[fmat1, cmat2];
                for (int i = 0; i < fmat1; i++)
                {
                    for (int j = 0; j < cmat2; j++)
                    {
                        MP[i, j] = 0;
                        for (incrementar = 0; incrementar < cmat1; incrementar++)
                        {
                            MP[i,j]+= M1[i, incrementar] * M2[incrementar, j];
                        }
                    }
                }

                //Mostrar en pantalla la matriz resultante
                Console.WriteLine("La matriz resultante de multiplicar M1 x M2 es:\n\n MP:");
                for (int i = 0; i < fmat1; i++)
                {
                    for (int j = 0; j < cmat2; j++)
                    {
                        Console.Write("    " + MP[i, j] + "    ");
                    }
                    Console.WriteLine();

                }
            }else
            {
                Console.WriteLine("La cantidad de columnas de la primera matriz no coinciden con la cantidad de filas de la segunda. Por favor introduzca dos matrices validas");
            }

        }
    }
}
