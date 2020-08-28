using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace Retencion
{
    class Program
    {
        static void Main(string[] args)
        {

            double SalBase;
            double SalNeto,SalNeto2;
            double ReteFuente1 = 0.05;
            double ReteFuente2 = 0.08;


            Console.WriteLine("Digite el salario Base del Empleado: ");
            SalBase = double.Parse(Console.ReadLine());

            if (SalBase > 1500 || SalBase<=3000)
            {
                SalNeto = SalBase - (SalBase * ReteFuente1);
                Console.WriteLine("El salario neto del trabajor es: " + SalNeto);
            }
            else if(SalBase>3000)
            {
                SalNeto2 = SalBase - (SalBase * ReteFuente2);
                Console.WriteLine("El salario neto de este trabajador es: " + SalNeto2);
            }    
            else
            {

                Console.WriteLine("EL salario neto del trabajador es: " + SalBase);

            }




        }
    }
}
