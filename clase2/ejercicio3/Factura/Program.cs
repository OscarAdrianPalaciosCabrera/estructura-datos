﻿using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace Factura
{
    class Program
    {
        static void Main(string[] args)
        {
            double va1, cant, descuento, iva, Total, precio2;

            Console.WriteLine("Digite el valor del producto");
            va1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad del producto");
            cant = double.Parse(Console.ReadLine());

            iva = (va1 * cant) * 0.11;
            precio2 = (va1 * cant) + iva;


            if (precio2 > 500)
            {
                descuento = precio2 * 0.06;
                Total = precio2 - descuento;
                Console.WriteLine("EL total a pagar es de: " + Total);
            }
            else
            {
                Console.WriteLine("El total a pagar es de: " + precio2);
            }


        }
    }
}


