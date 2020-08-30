using System;
using System.Net.Http.Headers;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 2).
                          
            Dados 10 números introducidos por teclado,
            visualizar la suma de los números pares de la lista, cuantos números pares existen
            y cuál es la media aritmética de los números impares*/

            
            float media, i, num, sumapar = 0, contp = 0, sumimpar = 0;

            string entrada;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("por favor introduzca un numero");
                entrada = Console.ReadLine();
                num = Convert.ToInt32(entrada);

                if (num % 2 == 0)
                {
                    sumapar = sumapar + num;
                    contp = contp + 1;
                }
                else
                {
                    sumimpar = sumimpar + num;
                }
            }

            media = sumimpar / 10;

            Console.WriteLine("la suma de los numeros pares de su lista es: {0}", sumapar);
            Console.WriteLine("usted digito un total de {0} numeros pares", contp);
            Console.WriteLine("la media aritmetica de los numeros impares de su ista es: {0}", media);
        }
    }
}
