using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;


namespace Matriz4
{
    class Program
    {
		static void Main(string[] args)
		{
			int i;
			int j;
			int nmenor;
			string[,] m = new string[50, 50];
			nmenor = 1;

			Console.WriteLine("INGRESE DATOS DE LA 1A MATRIZ");
				for (i = 1; i <= 10; i++)
				{
					for (j = 1; j <= 10; j++)
					{
						Console.WriteLine("INGRESE DATO DE LA POSICION " + i + "," + j);
						m[i - 1, j - 1] = Console.ReadLine();

					  if (m[i - 1, j - 1] <= nmenor)
					{
						   nmenor = m[i - 1, j - 1];
					}

				}
				}
				Console.WriteLine("");
	

			for (i = 1; i <= 10; i++)
				{
					for (j = 1; j <= 10; j++)
					{
						Console.Write(m[i - 1, j - 1] + " ");
					}
					Console.WriteLine("");
				}
				Console.WriteLine("");
				Console.WriteLine("El valor menor de la diagonal es :" + nmenor);
		}

	}

}