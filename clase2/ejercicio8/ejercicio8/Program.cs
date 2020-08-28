using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*8.Diseñar un algoritmo en el que a partir 
              de una fecha introducida por teclado con el formato 
              DIA, MES, AÑO, se obtenga la fecha del día siguiente.*/

            int d, m, a;
            string entrada;

            Console.WriteLine("inserte el dia");
            entrada = Console.ReadLine();
            d = Convert.ToInt32(entrada);

            Console.WriteLine("inserte el mes");
            entrada = Console.ReadLine();
            m = Convert.ToInt32(entrada);

            Console.WriteLine("inserte el año");
            entrada = Console.ReadLine();
            a = Convert.ToInt32(entrada);

            if (m == 1 && d == 31 || m == 2 && d == 29 || m == 3 && d == 31 || m == 4 && d == 30 || m == 5 && d == 31 || m == 6 && d == 30 || m == 7 && d == 31 || m == 8 && d == 31 || m == 9 && d == 30 || m == 10 && d == 31 || m == 11 && d == 30){
                Console.WriteLine("la fecha de mañana sera: 1/{0}/{1}", m + 1, a);
            }else if (d == 31 && m == 12) {
                Console.WriteLine("la fecha de mañana sera: 1/1/{0}", a + 1);
            }else{ 
                Console.WriteLine("la fecha de mañana sera: {0}/{1}/{2}", d + 1, m, a);
            }
                        
        }
    }
}
