using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Matriz3
{
	class Program
	{

		static void Main(string[] args)
		{
			int a;
			int b;
			int i;
			int j;
			string[,] m = new string[50, 50];
			string[] vd = new string[5];
			
			       // Introduccion de numeros para rellenar la matriz 5*5

					for (i = 1; i <= 5; i++)
					{
						for (j = 1; j <= 5; j++)
						{
							Console.WriteLine("Digite un numero para la posicion " + i + "," + j);
							m[i - 1, j - 1] = Console.ReadLine();

							// Diagonal del vector
							if (j == i)
							{
								vd[i - 1] = m[i - 1, j - 1];
							}
						}
					}

					
					// Imprimir matriz//
					for (j = 1; j <= 5; j++)
					{
						for (i = 1; i <= 5; i++)
						{
							Console.Write(m[i - 1, j - 1] + " ");
						}
						Console.WriteLine("");
					}

					Console.WriteLine("");
					Console.WriteLine("La diagonal del vector es: ");
			        Console.WriteLine("");

		           	for (i = 1; i <= 5; i++)
					{
						Console.WriteLine(vd[i - 1]);
					}
				}
			}
			}




