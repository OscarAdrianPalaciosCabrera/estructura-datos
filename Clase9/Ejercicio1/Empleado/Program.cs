using System;

/*Confeccionar una clase que represente un empleado. Definir como atributos su nombre y su sueldo.
En el constructor cargar los atributos y luego en otro método imprimir sus datos y por último uno que imprima 
un mensaje si debe pagar impuestos (si el sueldo supera a 3000)*/

namespace Empleado
{
    class Empl1
    {
        //Declaramos el tipo y las variables que vamos a utilizar en este ejercicio
        private string nombre;
        private double sueldo;

        //Utilizamos este metodo constructor para rellenar las variables
        public Empl1()
        {
            Console.WriteLine("Ingrese el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo del empleado");
            sueldo = int.Parse(Console.ReadLine());
        }

        //Creamos un metodo llamado mostrar, que imprima por pantalla el nombre y sueldo del empleado
        public void Mostrar()
        {
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Nombre");
            Console.WriteLine(nombre);
            Console.WriteLine("");
            Console.WriteLine("Sueldo");
            Console.WriteLine(sueldo);
        }

        //Creaos un metodo que nos indique, utilizando un condicional (if) si el empleado debe o no pagar impuesto
        public void Impuesto()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("El sueldo del empleado supera el estandar debe pagar impuesto");
            }
            else
            {
                Console.WriteLine("El empleado NO debe pagar impuesto, ya que el sueldo no supera el estandar");
            }

            //Agregamos un ReadKey para finalizar la ejecucion del programa cuando el usuario presione una tecla
            Console.ReadKey();
        }

        //Por medo del metodo Main hacemos llamado a los demas demas metodos para correr el programa
        static void Main(string[] args)
        {
            Empl1 emp = new Empl1();
            emp.Mostrar();
            emp.Impuesto();
        }
    }
}
