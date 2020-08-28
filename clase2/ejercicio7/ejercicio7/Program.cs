using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace leer_3_nums_calcular_el_medio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7.Dados tres números diferentes,
               deducir cual es el central*/

            int n1, n2, n3;
            string entrada;


            Console.WriteLine("Digite el primer numero");
            entrada = Console.ReadLine();
            n1 = Convert.ToInt32(entrada);

            Console.WriteLine("Digite el segundo numero");
            entrada = Console.ReadLine();
            n2 = Convert.ToInt32(entrada);

            Console.WriteLine("Digite el tercer numero");
            entrada = Console.ReadLine();
            n3 = Convert.ToInt32(entrada);


            if (n1 < n2 && n1 > n3 || n1 > n2 && n1 < n3) {
                Console.WriteLine("El numero central es el {0}", n1);
            } else if (n2 < n1 && n2 > n3 || n2 > n1 && n2 < n3){
                Console.WriteLine("El numero central  es el {0}", n2);
            }else if (n3 < n1 && n3 > n2 || n3 > n1 && n3 < n2){
                Console.WriteLine("El numero central  es el {0}", n3);
            }                                                              
        }
    }
}
