using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace NuMayMen
{
    class Program
    {
        static void Main(string[] args)
        {

            int N1, N2, N3, N4;

            Console.WriteLine("Ingrese el primer numero: ");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero: ");
            N3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero: ");
            N4 = int.Parse(Console.ReadLine());

            if (N1 > N2 && N1 > N3 && N1 > N4)
                Console.WriteLine("El numero mayor es: " + N1);
            if (N2 > N1 && N2 > N3 && N2 > N4)
                Console.WriteLine("El numero mayor es: " + N2);
            if (N3 > N1 && N3 > N2 && N3 > N4)
                Console.WriteLine("El numero mayor es: " + N3);
            if (N4 > N1 && N4 > N3 && N4 > N2)
                Console.WriteLine("El numero mayor es: " + N4);


        }
    }
}
