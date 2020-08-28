using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace NumPrim
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0, i, n;

            Console.WriteLine("Ingrese numero");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i < (n + 1); i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                Console.WriteLine("EL numero no es Primo");
            }
            else
            {
                Console.WriteLine("El numero si es Primo");
            }
        }
    }
}