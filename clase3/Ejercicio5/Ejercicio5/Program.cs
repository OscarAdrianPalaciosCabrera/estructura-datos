using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dat = new int[5];
            int i, may = 0, j = 0;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite el valor del numero {0}", (i + 1));
                dat[i] = Convert.ToInt32(Console.ReadLine());
            }
            while (j < 5)
            {
                if (dat[j] > may)
                    may = dat[j];
                j++;
            }
            Console.WriteLine("El numero mayor de los datos es {0}", may);
            Console.ReadKey();

        }
    }
}

