using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace Comision
{
    class Program
    {
        static void Main(string[] args)
        {
            int articulo;
            double comison1 = 0.05;
            double comision2 = 0.07;
            double comisionf;

            Console.WriteLine("Ingrese el valor del articulo: ");
            articulo = int.Parse(Console.ReadLine());

            if (articulo < 10)
            {

                comisionf = (articulo * comison1);
                Console.WriteLine("Su comisión por este producto es de: " + comisionf + "BFS");

            }

            else if (articulo >= 10)
            {

                comisionf = (articulo * comision2);
                Console.WriteLine("Su comisión por este producto es de: " + comisionf + "BFS");

            }
            
        }
    }
}
