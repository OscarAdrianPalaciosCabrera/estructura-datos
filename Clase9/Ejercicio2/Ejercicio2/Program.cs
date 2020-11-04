using System;

namespace Ejercicio2
{
    class operaciones
    {
        //Definimos las variables a utilizar, indicando su tipo
        private int val1;
        private int val2;
        private int sum;
        private int rest;
        private int mult;
        private int div;

        //cargamos dentro del metodo constructor los datos que vamos a utilizar
        public operaciones()
        {            
            val1 = 20;
            val2 = 10;
        }

        //Realizamos la suma de las dos variables en un metodo separado
        public void suma()
        {
            sum = val1 + val2;
        }

        //Realizamos la resta de las dos variables en un metodo separado
        public void resta()
        {
            rest = val1 - val2;
        }

        //Realizamos la multiplicacion de las dos variables en un metodo separado
        public void multiplicacion()
        {
            mult = val1 * val2;
        }

        //Realizamos la division de las dos variables en un metodo separado
        public void division()
        {
            div = val1 / val2;
        }

        //Utilizamos este metodo para imprimir los respectivos mensajes
        public void mostrar()
        {
            //Explicamos ele ejerccicio al usuario
            Console.WriteLine("En este ejercicio cargaremos 2 valores de tipo enteros en un constructor\ny posteriormente, en metodos diferentes " +
                "realizaremos la suma, resta, multiplicacion y division de los mismos");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////");

            Console.WriteLine("los valores que utilizaremos son: {0} y {1}", val1, val2);
            Console.WriteLine("//////////////////////////////////////////////////////////////////////");


            //Mostramos las operaciones y los resultados en pantalla
            Console.WriteLine("La suma de {0} + {1} es = {2}",val1,val2,sum);
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("La resta de {0} - {1} es = {2}", val1, val2, rest);
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("La multiplicacion de {0} x {1} es = {2}", val1, val2, mult);
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("La division de {0} / {1} es = {2}", val1, val2, div);
            Console.WriteLine("//////////////////////////////////////////////////////////////////////");

            //Agregamos un ReadKey para finalizar la ejecucion del programa cuando el usuario presione una tecla
            Console.ReadKey();
        }

        //Por medo del metodo Main hacemos llamado a los demas demas metodos para correr el programa
        static void Main(string[] args)
        {
            operaciones oper = new operaciones();
            oper.suma();
            oper.resta();
            oper.multiplicacion();
            oper.division();
            oper.mostrar();
        }
    }
}
