using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Ejercicio6
    {
         private int[,] matriz;
            
        public void introducir()
        {
            matriz = new int[5, 6];

            Console.WriteLine("Este ejericio permite llenar una matriz 5 x 6 e imprimir cuantos numeros son ceros, cuantos positivos y cuantos negativos\n");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("Digite el elemento de la posicion [" + (i + 1) + "  " + (j + 1) + "]: ");
                    string ingresar;
                    ingresar = Console.ReadLine();                   
                    matriz[i, j] = int.Parse(ingresar);
                    
                }
            }
            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////\n");
        }
        public void condiciones()
        {
            int sumcer = 0, sumpos = 0, sumneg = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (matriz[i, j] == 0)
                    {
                        sumcer = sumcer + 1;
                    }
                    else if (matriz[i, j] > 0)
                    {
                        sumpos = sumpos + 1; 
                    }
                    else
                    {
                        sumneg = sumneg + 1;
                    }
                }
            }
            Console.WriteLine("Usted dijito {0} ceros, {1} numeros positivos y {2} numeros negativos", sumcer, sumpos, sumneg);
        }

        static void Main(string[] args)
        { 
            Ejercicio6 ej = new Ejercicio6();
            ej.introducir();
            ej.condiciones();
        }
    }
}
